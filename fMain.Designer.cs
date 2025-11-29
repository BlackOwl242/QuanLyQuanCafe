namespace QuanLyQuanCaPhe
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pbToggleMenu = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTableManagement = new System.Windows.Forms.Panel();
            this.btnTableManagement = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlFoodAndDrinks = new System.Windows.Forms.Panel();
            this.btnFoodAndDninks = new System.Windows.Forms.Button();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.btnEvent = new System.Windows.Forms.Button();
            this.pnlAccountManagement = new System.Windows.Forms.Panel();
            this.btnAccountManager = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.pnlClientManagement = new System.Windows.Forms.Panel();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbToggleMenu)).BeginInit();
            this.pnlTableManagement.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlFoodAndDrinks.SuspendLayout();
            this.pnlEvent.SuspendLayout();
            this.pnlAccountManagement.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlClientManagement.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pnlTopMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 74);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.lblTitle.Location = new System.Drawing.Point(633, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Peru;
            this.pnlTopMenu.Controls.Add(this.lblDisplayName);
            this.pnlTopMenu.Controls.Add(this.pbToggleMenu);
            this.pnlTopMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(239, 73);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.lblDisplayName.Location = new System.Drawing.Point(71, 21);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(165, 32);
            this.lblDisplayName.TabIndex = 2;
            this.lblDisplayName.Text = "DisplayName";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbToggleMenu
            // 
            this.pbToggleMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbToggleMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbToggleMenu.BackgroundImage")));
            this.pbToggleMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbToggleMenu.Location = new System.Drawing.Point(11, 12);
            this.pbToggleMenu.Name = "pbToggleMenu";
            this.pbToggleMenu.Size = new System.Drawing.Size(46, 46);
            this.pbToggleMenu.TabIndex = 0;
            this.pbToggleMenu.TabStop = false;
            this.pbToggleMenu.Click += new System.EventHandler(this.pbToggleMenu_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(240, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1040, 654);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlTableManagement
            // 
            this.pnlTableManagement.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableManagement.Controls.Add(this.btnTableManagement);
            this.pnlTableManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlTableManagement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableManagement.Name = "pnlTableManagement";
            this.pnlTableManagement.Size = new System.Drawing.Size(239, 73);
            this.pnlTableManagement.TabIndex = 1;
            // 
            // btnTableManagement
            // 
            this.btnTableManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnTableManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTableManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnTableManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnTableManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnTableManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTableManagement.Image")));
            this.btnTableManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableManagement.Location = new System.Drawing.Point(-10, -10);
            this.btnTableManagement.Name = "btnTableManagement";
            this.btnTableManagement.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTableManagement.Size = new System.Drawing.Size(258, 93);
            this.btnTableManagement.TabIndex = 0;
            this.btnTableManagement.Text = "    Quản lý bàn";
            this.btnTableManagement.UseVisualStyleBackColor = false;
            this.btnTableManagement.Click += new System.EventHandler(this.btnTableManagement_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMenu.Controls.Add(this.pnlFoodAndDrinks);
            this.pnlMenu.Controls.Add(this.pnlEvent);
            this.pnlMenu.Controls.Add(this.pnlAccountManagement);
            this.pnlMenu.Controls.Add(this.pnlCategory);
            this.pnlMenu.Controls.Add(this.pnlTableManagement);
            this.pnlMenu.Controls.Add(this.pnlClientManagement);
            this.pnlMenu.Controls.Add(this.pnlRevenue);
            this.pnlMenu.Controls.Add(this.pbSetting);
            this.pnlMenu.Controls.Add(this.pnlTable);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 74);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 654);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlFoodAndDrinks
            // 
            this.pnlFoodAndDrinks.BackColor = System.Drawing.Color.Transparent;
            this.pnlFoodAndDrinks.Controls.Add(this.btnFoodAndDninks);
            this.pnlFoodAndDrinks.Location = new System.Drawing.Point(0, 433);
            this.pnlFoodAndDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFoodAndDrinks.Name = "pnlFoodAndDrinks";
            this.pnlFoodAndDrinks.Size = new System.Drawing.Size(239, 73);
            this.pnlFoodAndDrinks.TabIndex = 2;
            // 
            // btnFoodAndDninks
            // 
            this.btnFoodAndDninks.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodAndDninks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnFoodAndDninks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnFoodAndDninks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodAndDninks.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnFoodAndDninks.Image = global::QuanLyQuanCaPhe.Properties.Resources.Food;
            this.btnFoodAndDninks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodAndDninks.Location = new System.Drawing.Point(-10, -10);
            this.btnFoodAndDninks.Name = "btnFoodAndDninks";
            this.btnFoodAndDninks.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnFoodAndDninks.Size = new System.Drawing.Size(258, 93);
            this.btnFoodAndDninks.TabIndex = 0;
            this.btnFoodAndDninks.Text = "          Đồ ăn và uống";
            this.btnFoodAndDninks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodAndDninks.UseVisualStyleBackColor = false;
            this.btnFoodAndDninks.Click += new System.EventHandler(this.btnFoodAndDninks_Click);
            // 
            // pnlEvent
            // 
            this.pnlEvent.BackColor = System.Drawing.Color.Transparent;
            this.pnlEvent.Controls.Add(this.btnEvent);
            this.pnlEvent.Location = new System.Drawing.Point(1, 221);
            this.pnlEvent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(239, 73);
            this.pnlEvent.TabIndex = 14;
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnEvent.Image = global::QuanLyQuanCaPhe.Properties.Resources.Event;
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.Location = new System.Drawing.Point(-10, -10);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(258, 93);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "          Sự kiện";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.UseMnemonic = false;
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // pnlAccountManagement
            // 
            this.pnlAccountManagement.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountManagement.Controls.Add(this.btnAccountManager);
            this.pnlAccountManagement.Location = new System.Drawing.Point(1, 506);
            this.pnlAccountManagement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccountManagement.Name = "pnlAccountManagement";
            this.pnlAccountManagement.Size = new System.Drawing.Size(239, 73);
            this.pnlAccountManagement.TabIndex = 3;
            // 
            // btnAccountManager
            // 
            this.btnAccountManager.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnAccountManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnAccountManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManager.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAccountManager.Image = global::QuanLyQuanCaPhe.Properties.Resources.Account_;
            this.btnAccountManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountManager.Location = new System.Drawing.Point(-10, -10);
            this.btnAccountManager.Name = "btnAccountManager";
            this.btnAccountManager.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAccountManager.Size = new System.Drawing.Size(258, 93);
            this.btnAccountManager.TabIndex = 0;
            this.btnAccountManager.Text = "          Quản lý \r\n          tài khoản";
            this.btnAccountManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountManager.UseMnemonic = false;
            this.btnAccountManager.UseVisualStyleBackColor = false;
            this.btnAccountManager.Click += new System.EventHandler(this.btnAccountManager_Click);
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.Controls.Add(this.btnCategory);
            this.pnlCategory.Location = new System.Drawing.Point(1, 365);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(239, 73);
            this.pnlCategory.TabIndex = 2;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCategory.Image = global::QuanLyQuanCaPhe.Properties.Resources.Category;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(-10, -10);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(258, 93);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Danh mục";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pnlClientManagement
            // 
            this.pnlClientManagement.BackColor = System.Drawing.Color.Transparent;
            this.pnlClientManagement.Controls.Add(this.btnClientManagement);
            this.pnlClientManagement.Location = new System.Drawing.Point(1, 146);
            this.pnlClientManagement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlClientManagement.Name = "pnlClientManagement";
            this.pnlClientManagement.Size = new System.Drawing.Size(239, 73);
            this.pnlClientManagement.TabIndex = 3;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnClientManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnClientManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnClientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnClientManagement.Image = global::QuanLyQuanCaPhe.Properties.Resources.Client1;
            this.btnClientManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientManagement.Location = new System.Drawing.Point(-10, -12);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnClientManagement.Size = new System.Drawing.Size(258, 93);
            this.btnClientManagement.TabIndex = 1;
            this.btnClientManagement.Text = "          Quản lý \r\n          khách hàng";
            this.btnClientManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientManagement.UseMnemonic = false;
            this.btnClientManagement.UseVisualStyleBackColor = false;
            this.btnClientManagement.Click += new System.EventHandler(this.btnClientManagement_Click);
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.Transparent;
            this.pnlRevenue.Controls.Add(this.btnRevenue);
            this.pnlRevenue.Location = new System.Drawing.Point(1, 292);
            this.pnlRevenue.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(239, 73);
            this.pnlRevenue.TabIndex = 2;
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnRevenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.Image = global::QuanLyQuanCaPhe.Properties.Resources.Revenue;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(-10, -10);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnRevenue.Size = new System.Drawing.Size(258, 93);
            this.btnRevenue.TabIndex = 0;
            this.btnRevenue.Text = "  Doanh thu";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // pbSetting
            // 
            this.pbSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSetting.BackColor = System.Drawing.Color.Transparent;
            this.pbSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSetting.BackgroundImage")));
            this.pbSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSetting.Location = new System.Drawing.Point(12, 596);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(46, 46);
            this.pbSetting.TabIndex = 13;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.BackColor = System.Drawing.Color.Transparent;
            this.pnlTable.Controls.Add(this.btnTable);
            this.pnlTable.Location = new System.Drawing.Point(1, 73);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(239, 73);
            this.pnlTable.TabIndex = 2;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable.Image = global::QuanLyQuanCaPhe.Properties.Resources.Food_Table;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(-9, -12);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTable.Size = new System.Drawing.Size(258, 101);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "          Bàn ăn";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 728);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý của hàng đồ ăn nhanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbToggleMenu)).EndInit();
            this.pnlTableManagement.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFoodAndDrinks.ResumeLayout(false);
            this.pnlEvent.ResumeLayout(false);
            this.pnlAccountManagement.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlClientManagement.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.pnlTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.PictureBox pbToggleMenu;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTableManagement;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel pnlFoodAndDrinks;
        private System.Windows.Forms.Button btnFoodAndDninks;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnTableManagement;
        private System.Windows.Forms.Panel pnlAccountManagement;
        private System.Windows.Forms.Button btnAccountManager;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Panel pnlClientManagement;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Button btnEvent;
    }
}