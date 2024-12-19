namespace InventorySystem
{
    partial class StaffShelf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffShelf));
            this.dgvShelf = new System.Windows.Forms.DataGridView();
            this.btShelf = new System.Windows.Forms.Button();
            this.btInventory = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.btStaffLogout = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShelf
            // 
            this.dgvShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShelf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShelf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShelf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShelf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShelf.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShelf.EnableHeadersVisualStyles = false;
            this.dgvShelf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShelf.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvShelf.Location = new System.Drawing.Point(211, 110);
            this.dgvShelf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShelf.Name = "dgvShelf";
            this.dgvShelf.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShelf.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShelf.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShelf.ShowEditingIcon = false;
            this.dgvShelf.Size = new System.Drawing.Size(1581, 726);
            this.dgvShelf.TabIndex = 20;
            // 
            // btShelf
            // 
            this.btShelf.BackColor = System.Drawing.Color.DimGray;
            this.btShelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShelf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShelf.ForeColor = System.Drawing.Color.White;
            this.btShelf.Location = new System.Drawing.Point(29, 192);
            this.btShelf.Margin = new System.Windows.Forms.Padding(4);
            this.btShelf.Name = "btShelf";
            this.btShelf.Size = new System.Drawing.Size(133, 47);
            this.btShelf.TabIndex = 23;
            this.btShelf.Text = "Shelf";
            this.btShelf.UseVisualStyleBackColor = false;
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
            this.btInventory.TabIndex = 21;
            this.btInventory.Text = "Inventory";
            this.btInventory.UseVisualStyleBackColor = false;
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
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
            this.btSales.TabIndex = 22;
            this.btSales.Text = "Sales";
            this.btSales.UseVisualStyleBackColor = false;
            this.btSales.Click += new System.EventHandler(this.btSales_Click);
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
            this.lUser.TabIndex = 30;
            this.lUser.Text = "label2";
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
            this.btStaffLogout.TabIndex = 31;
            this.btStaffLogout.Text = "LogOut";
            this.btStaffLogout.UseVisualStyleBackColor = false;
            this.btStaffLogout.Click += new System.EventHandler(this.btStaffLogout_Click);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "ProductBrand",
            "ProductCategory",
            "ProductPrice",
            "ExpirationDate"});
            this.cbSort.Location = new System.Drawing.Point(1595, 68);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(196, 33);
            this.cbSort.TabIndex = 32;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
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
            this.pictureBox1.TabIndex = 33;
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
            this.panel2.TabIndex = 34;
            this.panel2.TabStop = true;
            // 
            // StaffShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1827, 871);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btStaffLogout);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.btShelf);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.dgvShelf);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffShelf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShelf;
        private System.Windows.Forms.Button btShelf;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button btStaffLogout;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}