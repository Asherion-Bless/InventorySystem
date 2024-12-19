namespace InventorySystem
{
    partial class AdminInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle113 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle114 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle115 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle116 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle117 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle118 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle119 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle120 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdminLogout = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.btInventory = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btRecords = new System.Windows.Forms.Button();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dgvNotification = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btShelf = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.btAutofill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdminLogout
            // 
            this.btAdminLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdminLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdminLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdminLogout.ForeColor = System.Drawing.Color.Black;
            this.btAdminLogout.Location = new System.Drawing.Point(29, 789);
            this.btAdminLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btAdminLogout.Name = "btAdminLogout";
            this.btAdminLogout.Size = new System.Drawing.Size(133, 47);
            this.btAdminLogout.TabIndex = 0;
            this.btAdminLogout.Text = "LogOut";
            this.btAdminLogout.UseVisualStyleBackColor = false;
            this.btAdminLogout.Click += new System.EventHandler(this.btAdminLogout_Click);
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.Black;
            this.btUser.Location = new System.Drawing.Point(29, 357);
            this.btUser.Margin = new System.Windows.Forms.Padding(4);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(133, 47);
            this.btUser.TabIndex = 1;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btSales
            // 
            this.btSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSales.ForeColor = System.Drawing.Color.Black;
            this.btSales.Location = new System.Drawing.Point(29, 273);
            this.btSales.Margin = new System.Windows.Forms.Padding(4);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(133, 47);
            this.btSales.TabIndex = 2;
            this.btSales.Text = "Sales";
            this.btSales.UseVisualStyleBackColor = false;
            this.btSales.Click += new System.EventHandler(this.btSales_Click);
            // 
            // btInventory
            // 
            this.btInventory.BackColor = System.Drawing.Color.DimGray;
            this.btInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInventory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInventory.ForeColor = System.Drawing.Color.White;
            this.btInventory.Location = new System.Drawing.Point(29, 110);
            this.btInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(133, 47);
            this.btInventory.TabIndex = 0;
            this.btInventory.Text = "Inventory";
            this.btInventory.UseVisualStyleBackColor = false;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle113.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle113.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle113.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle113.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle113.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle113.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle113.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle113;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle114.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle114.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle114.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle114.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle114.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle114.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle114.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle114;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvInventory.Location = new System.Drawing.Point(207, 112);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventory.Name = "dgvInventory";
            dataGridViewCellStyle115.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle115.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle115.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle115.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle115.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle115.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle115;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle116.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle116.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle116.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle116;
            this.dgvInventory.ShowEditingIcon = false;
            this.dgvInventory.Size = new System.Drawing.Size(1581, 521);
            this.dgvInventory.TabIndex = 4;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            this.dgvInventory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInventory_DataBindingComplete);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(256, 55);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(439, 47);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btRecords
            // 
            this.btRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRecords.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecords.ForeColor = System.Drawing.Color.Black;
            this.btRecords.Location = new System.Drawing.Point(29, 439);
            this.btRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btRecords.Name = "btRecords";
            this.btRecords.Size = new System.Drawing.Size(133, 47);
            this.btRecords.TabIndex = 6;
            this.btRecords.Text = "Records";
            this.btRecords.UseVisualStyleBackColor = false;
            this.btRecords.Click += new System.EventHandler(this.btRecords_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(207, 55);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(56, 47);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 7;
            this.pbSearch.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1279, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(1487, 53);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 49);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.Location = new System.Drawing.Point(1175, 53);
            this.btImport.Margin = new System.Windows.Forms.Padding(4);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(96, 49);
            this.btImport.TabIndex = 10;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "ProductBrand",
            "ProductCategory",
            "ProductPrice",
            "StockQuantity",
            "ReorderLevel",
            "DateStocked",
            "ExpirationDate"});
            this.cbSort.Location = new System.Drawing.Point(1591, 58);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(196, 37);
            this.cbSort.TabIndex = 11;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(1383, 53);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(96, 49);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvNotification
            // 
            this.dgvNotification.AllowUserToDeleteRows = false;
            this.dgvNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotification.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNotification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle117.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle117.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle117.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle117.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle117.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle117.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle117.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle117;
            this.dgvNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle118.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle118.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle118.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle118.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle118.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle118.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle118.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotification.DefaultCellStyle = dataGridViewCellStyle118;
            this.dgvNotification.EnableHeadersVisualStyles = false;
            this.dgvNotification.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNotification.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvNotification.Location = new System.Drawing.Point(207, 681);
            this.dgvNotification.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotification.Name = "dgvNotification";
            this.dgvNotification.ReadOnly = true;
            dataGridViewCellStyle119.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle119.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle119.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle119.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle119.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle119.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotification.RowHeadersDefaultCellStyle = dataGridViewCellStyle119;
            dataGridViewCellStyle120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle120.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle120.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle120.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNotification.RowsDefaultCellStyle = dataGridViewCellStyle120;
            this.dgvNotification.Size = new System.Drawing.Size(1581, 158);
            this.dgvNotification.TabIndex = 13;
            this.dgvNotification.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 652);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notification:";
            // 
            // btShelf
            // 
            this.btShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btShelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btShelf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShelf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShelf.ForeColor = System.Drawing.Color.Black;
            this.btShelf.Location = new System.Drawing.Point(29, 192);
            this.btShelf.Margin = new System.Windows.Forms.Padding(4);
            this.btShelf.Name = "btShelf";
            this.btShelf.Size = new System.Drawing.Size(133, 47);
            this.btShelf.TabIndex = 15;
            this.btShelf.Text = "Shelf";
            this.btShelf.UseVisualStyleBackColor = false;
            this.btShelf.Click += new System.EventHandler(this.btShelf_Click);
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.BackColor = System.Drawing.Color.Gray;
            this.lUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.Location = new System.Drawing.Point(83, 9);
            this.lUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(79, 29);
            this.lUser.TabIndex = 16;
            this.lUser.Text = "label2";
            // 
            // btAutofill
            // 
            this.btAutofill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAutofill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutofill.Location = new System.Drawing.Point(1071, 53);
            this.btAutofill.Margin = new System.Windows.Forms.Padding(4);
            this.btAutofill.Name = "btAutofill";
            this.btAutofill.Size = new System.Drawing.Size(96, 49);
            this.btAutofill.TabIndex = 17;
            this.btAutofill.Text = "AutoFill";
            this.btAutofill.UseVisualStyleBackColor = true;
            this.btAutofill.Click += new System.EventHandler(this.btAutofill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1827, 51);
            this.panel2.TabIndex = 20;
            this.panel2.TabStop = true;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1827, 871);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAutofill);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.btShelf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNotification);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.btRecords);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btAdminLogout);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminInterface_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdminLogout;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btRecords;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dgvNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShelf;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button btAutofill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}