namespace InventorySystem
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btInventory = new System.Windows.Forms.Button();
            this.btShelf = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductSold = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.btAdminLogout = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSales.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvSales.Location = new System.Drawing.Point(743, 110);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSales.ShowEditingIcon = false;
            this.dgvSales.Size = new System.Drawing.Size(1041, 726);
            this.dgvSales.TabIndex = 5;
            // 
            // btInventory
            // 
            this.btInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInventory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInventory.ForeColor = System.Drawing.Color.Black;
            this.btInventory.Location = new System.Drawing.Point(29, 110);
            this.btInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(133, 47);
            this.btInventory.TabIndex = 6;
            this.btInventory.Text = "Inventory";
            this.btInventory.UseVisualStyleBackColor = false;
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
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
            this.btShelf.TabIndex = 16;
            this.btShelf.Text = "Shelf";
            this.btShelf.UseVisualStyleBackColor = false;
            this.btShelf.Click += new System.EventHandler(this.btShelf_Click);
            // 
            // btSales
            // 
            this.btSales.BackColor = System.Drawing.Color.DimGray;
            this.btSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSales.ForeColor = System.Drawing.Color.White;
            this.btSales.Location = new System.Drawing.Point(29, 273);
            this.btSales.Margin = new System.Windows.Forms.Padding(4);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(133, 47);
            this.btSales.TabIndex = 17;
            this.btSales.Text = "Sales";
            this.btSales.UseVisualStyleBackColor = false;
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
            this.btUser.TabIndex = 18;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
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
            this.btRecords.TabIndex = 19;
            this.btRecords.Text = "Records";
            this.btRecords.UseVisualStyleBackColor = false;
            this.btRecords.Click += new System.EventHandler(this.btRecords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sales Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "User ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 33);
            this.label6.TabIndex = 29;
            this.label6.Text = "Product Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Poduct Sold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(507, 453);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(220, 38);
            this.txtUserID.TabIndex = 25;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(508, 316);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(219, 38);
            this.txtProductPrice.TabIndex = 24;
            // 
            // txtProductSold
            // 
            this.txtProductSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSold.Location = new System.Drawing.Point(509, 242);
            this.txtProductSold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductSold.Multiline = true;
            this.txtProductSold.Name = "txtProductSold";
            this.txtProductSold.Size = new System.Drawing.Size(217, 38);
            this.txtProductSold.TabIndex = 23;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(505, 176);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(221, 38);
            this.txtProductName.TabIndex = 22;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(509, 112);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(217, 38);
            this.txtProductID.TabIndex = 21;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CustomFormat = "\" \"";
            this.dtpSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.Location = new System.Drawing.Point(508, 385);
            this.dtpSaleDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(219, 38);
            this.dtpSaleDate.TabIndex = 20;
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
            this.btAdminLogout.TabIndex = 32;
            this.btAdminLogout.Text = "LogOut";
            this.btAdminLogout.UseVisualStyleBackColor = false;
            this.btAdminLogout.Click += new System.EventHandler(this.btAdminLogout_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(511, 558);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 57);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(436, 782);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(287, 52);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(795, 59);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(479, 42);
            this.tbSearch.TabIndex = 35;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            this.lUser.TabIndex = 38;
            this.lUser.Text = "label2";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(743, 59);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(56, 43);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 39;
            this.pbSearch.TabStop = false;
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
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1827, 51);
            this.panel2.TabIndex = 41;
            this.panel2.TabStop = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1827, 884);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btAdminLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductSold);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.btRecords);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btShelf);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.Button btShelf;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductSold;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Button btAdminLogout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}