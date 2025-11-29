namespace QuanLyQuanCaPhe.UserControls
{
    partial class ucClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.lbClientName = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBonusPoint = new System.Windows.Forms.Label();
            this.txtBonusPoint = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.pnlDgv.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::QuanLyQuanCaPhe.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(19, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(138, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::QuanLyQuanCaPhe.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(369, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(138, 44);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(92)))), ((int)(((byte)(199)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::QuanLyQuanCaPhe.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(194, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(138, 44);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(110)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = global::QuanLyQuanCaPhe.Properties.Resources.view;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(544, 0);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(138, 44);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(92)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(19, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(80, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(606, 39);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClient.Location = new System.Drawing.Point(19, 0);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(667, 521);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvClient);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgv.Location = new System.Drawing.Point(0, 61);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Padding = new System.Windows.Forms.Padding(19, 0, 19, 20);
            this.pnlDgv.Size = new System.Drawing.Size(705, 541);
            this.pnlDgv.TabIndex = 7;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(-4, 70);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 21);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(105, 61);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(216, 35);
            this.txtID.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(705, 61);
            this.pnlTop.TabIndex = 6;
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(105, 106);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(216, 35);
            this.txtClientName.TabIndex = 7;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Controls.Add(this.btnView);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 602);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(705, 52);
            this.pnlButton.TabIndex = 5;
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientName.Location = new System.Drawing.Point(-4, 116);
            this.lbClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(65, 21);
            this.lbClientName.TabIndex = 8;
            this.lbClientName.Text = "Tên KH:";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlContent.Controls.Add(this.pnlDgv);
            this.pnlContent.Controls.Add(this.pnlTop);
            this.pnlContent.Controls.Add(this.pnlButton);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(705, 654);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlLeft.Controls.Add(this.lblBonusPoint);
            this.pnlLeft.Controls.Add(this.txtBonusPoint);
            this.pnlLeft.Controls.Add(this.lblEmail);
            this.pnlLeft.Controls.Add(this.txtEmail);
            this.pnlLeft.Controls.Add(this.lblPhoneNum);
            this.pnlLeft.Controls.Add(this.txtPhoneNum);
            this.pnlLeft.Controls.Add(this.lbClientName);
            this.pnlLeft.Controls.Add(this.txtClientName);
            this.pnlLeft.Controls.Add(this.lbID);
            this.pnlLeft.Controls.Add(this.txtID);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(705, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(335, 654);
            this.pnlLeft.TabIndex = 2;
            // 
            // lblBonusPoint
            // 
            this.lblBonusPoint.AutoSize = true;
            this.lblBonusPoint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusPoint.Location = new System.Drawing.Point(-4, 249);
            this.lblBonusPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBonusPoint.Name = "lblBonusPoint";
            this.lblBonusPoint.Size = new System.Drawing.Size(105, 21);
            this.lblBonusPoint.TabIndex = 17;
            this.lblBonusPoint.Text = "Điểm đã tích:";
            // 
            // txtBonusPoint
            // 
            this.txtBonusPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonusPoint.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonusPoint.Location = new System.Drawing.Point(105, 240);
            this.txtBonusPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtBonusPoint.Name = "txtBonusPoint";
            this.txtBonusPoint.Size = new System.Drawing.Size(216, 35);
            this.txtBonusPoint.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(-4, 203);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 21);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(105, 194);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 35);
            this.txtEmail.TabIndex = 14;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(-4, 159);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(43, 21);
            this.lblPhoneNum.TabIndex = 13;
            this.lblPhoneNum.Text = "SĐT:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(105, 150);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(216, 35);
            this.txtPhoneNum.TabIndex = 12;
            // 
            // ucClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ucClient";
            this.Size = new System.Drawing.Size(1040, 654);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.pnlDgv.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBonusPoint;
        private System.Windows.Forms.TextBox txtBonusPoint;
    }
}
