namespace InventorySystem
{
    partial class StaffInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInterface));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btStaffLogout = new System.Windows.Forms.Button();
            this.btShelf = new System.Windows.Forms.Button();
            this.btInventory = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lUser = new System.Windows.Forms.Label();
            this.btAutofill = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStaffLogout
            // 
            this.btStaffLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStaffLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btStaffLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStaffLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStaffLogout.Location = new System.Drawing.Point(29, 789);
            this.btStaffLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btStaffLogout.Name = "btStaffLogout";
            this.btStaffLogout.Size = new System.Drawing.Size(133, 47);
            this.btStaffLogout.TabIndex = 0;
            this.btStaffLogout.Text = "LogOut";
            this.btStaffLogout.UseVisualStyleBackColor = false;
            this.btStaffLogout.Click += new System.EventHandler(this.btStaffLogout_Click);
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
            this.btShelf.TabIndex = 20;
            this.btShelf.Text = "Shelf";
            this.btShelf.UseVisualStyleBackColor = false;
            this.btShelf.Click += new System.EventHandler(this.btShelf_Click);
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
            this.btInventory.TabIndex = 16;
            this.btInventory.Text = "Inventory";
            this.btInventory.UseVisualStyleBackColor = false;
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
            this.btSales.TabIndex = 18;
            this.btSales.Text = "Sales";
            this.btSales.UseVisualStyleBackColor = false;
            this.btSales.Click += new System.EventHandler(this.btSales_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(211, 55);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(56, 47);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 23;
            this.pbSearch.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(265, 55);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(439, 47);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvInventory.Location = new System.Drawing.Point(211, 110);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventory.Name = "dgvInventory";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInventory.ShowEditingIcon = false;
            this.dgvInventory.Size = new System.Drawing.Size(1581, 726);
            this.dgvInventory.TabIndex = 21;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            this.dgvInventory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInventory_DataBindingComplete_1);
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
            this.lUser.TabIndex = 24;
            this.lUser.Text = "label2";
            // 
            // btAutofill
            // 
            this.btAutofill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAutofill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutofill.Location = new System.Drawing.Point(1283, 55);
            this.btAutofill.Margin = new System.Windows.Forms.Padding(4);
            this.btAutofill.Name = "btAutofill";
            this.btAutofill.Size = new System.Drawing.Size(96, 49);
            this.btAutofill.TabIndex = 32;
            this.btAutofill.Text = "AutoFill";
            this.btAutofill.UseVisualStyleBackColor = true;
            this.btAutofill.Click += new System.EventHandler(this.btAutofill_Click);
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
            this.cbSort.Location = new System.Drawing.Point(1595, 58);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(196, 37);
            this.cbSort.TabIndex = 30;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.Location = new System.Drawing.Point(1387, 55);
            this.btImport.Margin = new System.Windows.Forms.Padding(4);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(96, 49);
            this.btImport.TabIndex = 29;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1491, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 49);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1827, 51);
            this.panel2.TabIndex = 33;
            this.panel2.TabStop = true;
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
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // StaffInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1827, 871);
            this.Controls.Add(this.btAutofill);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btShelf);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btStaffLogout);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStaffLogout;
        private System.Windows.Forms.Button btShelf;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button btAutofill;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}