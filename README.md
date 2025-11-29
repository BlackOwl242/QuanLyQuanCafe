**1. YÊU CẦU HỆ THỐNG**

Để phần mềm hoạt động ổn định, bạn cần có:
* Hệ điều hành Windows 7 trở lên.
* .NET Framework 4.7.2.
* **Hệ quản trị cơ sở dữ liệu SQL Server** (phiên bản bất kỳ, ví dụ: SQL Server Express, SQL Server LocalDB).

---

**2. HƯỚNG DẪN SỬ DỤNG LẦN ĐẦU TIÊN (QUAN TRỌNG)**

Để đảm bảo phần mềm hoạt động chính xác, bạn **bắt buộc** phải thực hiện bước sau trước khi khởi chạy chương trình:

* **Chạy file "Create database.bat"**:
    Tìm và nhấp đúp vào file **"Create database.bat"** nằm trong thư mục cài đặt của phần mềm.
    File này sẽ tự động tạo cơ sở dữ liệu cần thiết cho phần mềm.
    Vui lòng chờ cho đến khi cửa sổ dòng lệnh tự động đóng lại.

---

**3. ĐĂNG NHẬP VÀO PHẦN MỀM**

Sau khi đã chạy file "Create database.bat", bạn có thể khởi động Phần mềm Quản lý Cửa hàng Đồ ăn nhanh.

* **Tên đăng nhập (Username):** admin
* **Mật khẩu (Password):** 0

---

**4. Setup sử dụng chức năng gửi mail cho khách hàng(Sự kiện)**
Để sử dụng chức năng gửi email cho khách hàng qua Gmail, bạn cần thực hiện các bước sau:
Bước 1: Đăng ký và cấu hình Google Cloud Project
* Truy cập Google Cloud Console.
* Tạo một Project mới hoặc sử dụng Project hiện có.
* Vào mục APIs & Services > Library, tìm và bật Gmail API cho Project của bạn.
Bước 2: Tạo OAuth 2.0 Credentials
* Vào APIs & Services > Credentials.
* Chọn Create Credentials > OAuth client ID.
* Chọn loại ứng dụng là Desktop app.
* Đặt tên bất kỳ, sau đó nhấn Create.
* Tải về file credentials.json và đặt vào thư mục gốc của phần mềm (cùng cấp với file thực thi .exe).
Bước 3: Đăng nhập Gmail lần đầu
* Khi sử dụng chức năng gửi mail lần đầu, phần mềm sẽ yêu cầu xác thực tài khoản Google.
* Một cửa sổ trình duyệt sẽ mở ra, bạn đăng nhập và cấp quyền cho ứng dụng.
* Sau khi xác thực thành công, phần mềm sẽ lưu thông tin đăng nhập vào file token.json (tự động tạo).
Bước 4: Sử dụng chức năng gửi mail
* Vào mục Sự kiện, nhập nội dung, chủ đề, chọn khách hàng hoặc gửi cho tất cả.
* Nhấn nút Gửi hoặc Gửi cho tất cả để gửi email.
Lưu ý quan trọng:
* File credentials.json là bắt buộc và phải đặt đúng vị trí.
* Tài khoản Google dùng để gửi mail phải có quyền truy cập Gmail.
* Nếu đổi máy hoặc xóa file token.json, bạn sẽ cần xác thực lại tài khoản Google.

---

**5. LIÊN HỆ HỖ TRỢ**

Nếu bạn có bất kỳ thắc mắc hoặc gặp vấn đề trong quá trình sử dụng, vui lòng liên hệ:
EMAIL: lequochuy@dev.adedmusic.com

---

Cảm ơn bạn đã sử dụng phần mềm của tôi!
Chúc bạn quản lý cửa hàng hiệu quả!

Trân trọng,
Lê Quốc Huy
