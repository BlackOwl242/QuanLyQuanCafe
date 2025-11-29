namespace QuanLyQuanCaPhe.UserControls
{
    partial class ucEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEvent));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlRichTextBox = new System.Windows.Forms.Panel();
            this.pnlSubject = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSendToAll = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRichTextBox.SuspendLayout();
            this.pnlSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            this.pnlUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlContent.Controls.Add(this.pnlRichTextBox);
            this.pnlContent.Controls.Add(this.pnlUpload);
            this.pnlContent.Controls.Add(this.pnlSubject);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(639, 654);
            this.pnlContent.TabIndex = 5;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvClient);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgv.Location = new System.Drawing.Point(0, 94);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Padding = new System.Windows.Forms.Padding(19, 0, 19, 20);
            this.pnlDgv.Size = new System.Drawing.Size(401, 560);
            this.pnlDgv.TabIndex = 7;
            // 
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClient.Location = new System.Drawing.Point(19, 0);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(363, 540);
            this.dgvClient.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(401, 94);
            this.pnlTop.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(19, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 39);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlLeft.Controls.Add(this.pnlDgv);
            this.pnlLeft.Controls.Add(this.pnlTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(639, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(401, 654);
            this.pnlLeft.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(92)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(324, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlRichTextBox
            // 
            this.pnlRichTextBox.Controls.Add(this.lblContent);
            this.pnlRichTextBox.Controls.Add(this.rtbContent);
            this.pnlRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRichTextBox.Location = new System.Drawing.Point(0, 94);
            this.pnlRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRichTextBox.Name = "pnlRichTextBox";
            this.pnlRichTextBox.Padding = new System.Windows.Forms.Padding(19, 40, 0, 20);
            this.pnlRichTextBox.Size = new System.Drawing.Size(319, 560);
            this.pnlRichTextBox.TabIndex = 8;
            // 
            // pnlSubject
            // 
            this.pnlSubject.Controls.Add(this.btnSend);
            this.pnlSubject.Controls.Add(this.lblSubject);
            this.pnlSubject.Controls.Add(this.btnSendToAll);
            this.pnlSubject.Controls.Add(this.txtSubject);
            this.pnlSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubject.Location = new System.Drawing.Point(0, 0);
            this.pnlSubject.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSubject.Name = "pnlSubject";
            this.pnlSubject.Size = new System.Drawing.Size(639, 94);
            this.pnlSubject.TabIndex = 9;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtSubject.Location = new System.Drawing.Point(19, 46);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(300, 39);
            this.txtSubject.TabIndex = 0;
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendToAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.btnSendToAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendToAll.ForeColor = System.Drawing.Color.White;
            this.btnSendToAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSendToAll.Image")));
            this.btnSendToAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendToAll.Location = new System.Drawing.Point(468, 44);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSendToAll.Size = new System.Drawing.Size(156, 40);
            this.btnSendToAll.TabIndex = 8;
            this.btnSendToAll.Text = "Gửi tất cả";
            this.btnSendToAll.UseVisualStyleBackColor = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(14, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(88, 30);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Chủ đề:";
            // 
            // rtbContent
            // 
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(19, 40);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(300, 500);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(14, 2);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(113, 30);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Nội dung:";
            // 
            // pbUpload
            // 
            this.pbUpload.BackColor = System.Drawing.Color.White;
            this.pbUpload.Location = new System.Drawing.Point(19, 39);
            this.pbUpload.Margin = new System.Windows.Forms.Padding(2);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(286, 273);
            this.pbUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpload.TabIndex = 12;
            this.pbUpload.TabStop = false;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(14, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(114, 30);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = "Đính kèm:";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(92)))), ((int)(((byte)(199)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(61, 327);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpload.Size = new System.Drawing.Size(209, 40);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Tải ảnh";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.lblPin);
            this.pnlUpload.Controls.Add(this.pbUpload);
            this.pnlUpload.Controls.Add(this.btnUpload);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpload.Location = new System.Drawing.Point(319, 94);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Padding = new System.Windows.Forms.Padding(20, 40, 0, 75);
            this.pnlUpload.Size = new System.Drawing.Size(320, 560);
            this.pnlUpload.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(92)))), ((int)(((byte)(199)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(338, 44);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 40);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // ucEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ucEvent";
            this.Size = new System.Drawing.Size(1040, 654);
            this.pnlContent.ResumeLayout(false);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRichTextBox.ResumeLayout(false);
            this.pnlRichTextBox.PerformLayout();
            this.pnlSubject.ResumeLayout(false);
            this.pnlSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).EndInit();
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Panel pnlRichTextBox;
        private System.Windows.Forms.Button btnSendToAll;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.PictureBox pbUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Button btnSend;
    }
}
