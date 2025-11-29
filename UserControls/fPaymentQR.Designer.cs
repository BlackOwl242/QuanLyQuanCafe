namespace QuanLyQuanCaPhe.UserControls
{
    partial class fPaymentQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPaymentQR));
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTilte = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTable.Location = new System.Drawing.Point(12, 48);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(78, 25);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Tên bàn";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(12, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Số tiền + VNĐ";
            // 
            // lblTilte
            // 
            this.lblTilte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTilte.AutoSize = true;
            this.lblTilte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilte.Location = new System.Drawing.Point(125, 9);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(278, 30);
            this.lblTilte.TabIndex = 2;
            this.lblTilte.Text = "Quét mã QR để thanh toán";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(409, 323);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 37);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQR.Location = new System.Drawing.Point(165, 116);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 4;
            this.pictureBoxQR.TabStop = false;
            // 
            // fPaymentQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTilte);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPaymentQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quét mã QR để thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBoxQR;
    }
}