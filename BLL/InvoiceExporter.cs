using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using QuanLyQuanCaPhe.DTO;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.BLL
{
    class InvoiceExporter
    {
        private string GetInvoiceDirectory()
        {
            // Gốc chương trình
            string root = Application.StartupPath;
            // Lấy ngày hiện tại
            DateTime now = DateTime.Now;
            // Tạo đường dẫn: Invoices\yyyy\MM\dd
            string invoiceDir = Path.Combine(root, "Invoices", now.Year.ToString(), now.Month.ToString("D2"), now.Day.ToString("D2"));
            // Tạo thư mục nếu chưa có
            if (!Directory.Exists(invoiceDir))
            {
                Directory.CreateDirectory(invoiceDir);
            }
            return invoiceDir;
        }

        public static void ExportInvoiceToXml(Table table, List<DTO.Menu> billInfo, double total, double discount, double finalTotal, string employeeName, string clientName)
        {
            InvoiceExporter exporter = new InvoiceExporter();
            string invoiceDir = exporter.GetInvoiceDirectory();
            string fileName = $"HoaDon_{table.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.xml";
            string filePath = Path.Combine(invoiceDir, fileName);
            string invoiceCode = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("HoaDon");
                writer.WriteElementString("MaHoaDon", invoiceCode);
                writer.WriteElementString("KhachHang", clientName);
                writer.WriteElementString("Ban", table.Name);
                writer.WriteElementString("Ngay", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                writer.WriteStartElement("DanhSachMon");

                foreach (var item in billInfo)
                {
                    writer.WriteStartElement("Mon");
                    writer.WriteElementString("TenMon", item.FoodName);
                    writer.WriteElementString("SoLuong", item.Count.ToString());
                    writer.WriteElementString("DonGia", item.Price.ToString());
                    writer.WriteElementString("ThanhTien", item.TotalPrice.ToString());
                    writer.WriteEndElement(); // Mon
                }

                writer.WriteEndElement(); // DanhSachMon

                writer.WriteElementString("TongCong", total.ToString());
                writer.WriteElementString("GiamGia", discount.ToString());
                writer.WriteElementString("ThanhTien", finalTotal.ToString());
                writer.WriteElementString("NhanVien", employeeName);
                writer.WriteEndElement(); // HoaDon
                writer.WriteEndDocument();
            }
        }

        public static void ExportInvoiceToPdf(Table table, List<DTO.Menu> billInfo, double total, double discount, double finalTotal, string employeeName, System.Drawing.Image qrImage, string clientName)
        {
            InvoiceExporter exporter = new InvoiceExporter();
            string invoiceDir = exporter.GetInvoiceDirectory();
            string fileName = $"HoaDon_{table.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(invoiceDir, fileName);
            string invoiceCode = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var fontTitle = new Font(bf, 16, Font.BOLD);
            var fontNormal = new Font(bf, 12, Font.NORMAL);

            Document doc = new Document(PageSize.A5, 20, 20, 20, 20);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                Paragraph title = new Paragraph("HÓA ĐƠN THANH TOÁN", fontTitle);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph _invoiceCode = new Paragraph($"Mã hóa đơn: {invoiceCode}", fontNormal);
                _invoiceCode.Alignment = Element.ALIGN_CENTER;
                doc.Add(_invoiceCode);

                doc.Add(new Paragraph($"Khách hàng: {clientName}", fontNormal));
                doc.Add(new Paragraph($"Bàn: {table.Name}", fontNormal));
                doc.Add(new Paragraph($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal));
                doc.Add(new Paragraph($"Nhân viên: {employeeName}", fontNormal));
                doc.Add(new Paragraph(" ", fontNormal));

                PdfPTable tablePdf = new PdfPTable(4);
                tablePdf.WidthPercentage = 100;
                tablePdf.SetWidths(new float[] { 4, 2, 2, 2 });

                tablePdf.AddCell(new PdfPCell(new Phrase("Tên món", fontNormal)));
                tablePdf.AddCell(new PdfPCell(new Phrase("Số lượng", fontNormal)));
                tablePdf.AddCell(new PdfPCell(new Phrase("Đơn giá", fontNormal)));
                tablePdf.AddCell(new PdfPCell(new Phrase("Thành tiền", fontNormal)));

                foreach (var item in billInfo)
                {
                    tablePdf.AddCell(new PdfPCell(new Phrase(item.FoodName, fontNormal)));
                    tablePdf.AddCell(new PdfPCell(new Phrase(item.Count.ToString(), fontNormal)));
                    tablePdf.AddCell(new PdfPCell(new Phrase(item.Price.ToString("N0"), fontNormal)));
                    tablePdf.AddCell(new PdfPCell(new Phrase(item.TotalPrice.ToString("N0"), fontNormal)));
                }

                doc.Add(tablePdf);

                doc.Add(new Paragraph(" ", fontNormal));
                doc.Add(new Paragraph($"Tổng cộng: {total:N0} VNĐ", fontNormal));
                doc.Add(new Paragraph($"Giảm giá: {discount}%", fontNormal));
                // Chèn một dòng trống, và một dấu ngang từ đầu đến cuối trang
                doc.Add(new Paragraph(" ", fontNormal));
                doc.Add(new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1));
                doc.Add(new Paragraph($"Thành tiền: {finalTotal:N0} VNĐ", fontTitle));

                doc.Add(new Paragraph(" ", fontNormal));
                doc.Add(new Paragraph("Quét mã QR để thanh toán", fontNormal) { Alignment = Element.ALIGN_CENTER });

                // Thêm QR code vào hóa đơn
                try
                {
                    using (var ms = new MemoryStream())
                    using (var bmp = new System.Drawing.Bitmap(qrImage))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        pdfImage.Alignment = Element.ALIGN_CENTER;
                        pdfImage.ScaleAbsolute(120f, 120f);
                        doc.Add(pdfImage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu QR: " + ex.Message);
                }

                doc.Close();
            }

            MessageBox.Show($"Hóa đơn PDF đã được lưu vào:\n{filePath}", "Thông báo");
        }
    }
}

