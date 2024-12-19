namespace InventorySystem
{
    partial class UserTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTab));
            this.btHistory = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btInventory = new System.Windows.Forms.Button();
            this.btSales = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btAdminLogout = new System.Windows.Forms.Button();
            this.btCreateAcc = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btShelf = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btHistory
            // 
            this.btHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btHistory.Location = new System.Drawing.Point(29, 433);
            this.btHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(133, 47);
            this.btHistory.TabIndex = 13;
            this.btHistory.Text = "Records";
            this.btHistory.UseVisualStyleBackColor = false;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsers.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvUsers.Location = new System.Drawing.Point(207, 110);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsers.Size = new System.Drawing.Size(1577, 726);
            this.dgvUsers.TabIndex = 11;
            // 
            // btInventory
            // 
            this.btInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInventory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btInventory.Location = new System.Drawing.Point(29, 110);
            this.btInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(133, 47);
            this.btInventory.TabIndex = 10;
            this.btInventory.Text = "Inventory";
            this.btInventory.UseVisualStyleBackColor = false;
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
            // 
            // btSales
            // 
            this.btSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btSales.Location = new System.Drawing.Point(29, 271);
            this.btSales.Margin = new System.Windows.Forms.Padding(4);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(133, 47);
            this.btSales.TabIndex = 9;
            this.btSales.Text = "Sales";
            this.btSales.UseVisualStyleBackColor = false;
            this.btSales.Click += new System.EventHandler(this.btSales_Click);
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.DimGray;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Location = new System.Drawing.Point(29, 354);
            this.btUser.Margin = new System.Windows.Forms.Padding(4);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(133, 47);
            this.btUser.TabIndex = 8;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btAdminLogout
            // 
            this.btAdminLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdminLogout.Location = new System.Drawing.Point(29, 789);
            this.btAdminLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btAdminLogout.Name = "btAdminLogout";
            this.btAdminLogout.Size = new System.Drawing.Size(133, 47);
            this.btAdminLogout.TabIndex = 15;
            this.btAdminLogout.Text = "LogOut";
            this.btAdminLogout.UseVisualStyleBackColor = true;
            this.btAdminLogout.Click += new System.EventHandler(this.btAdminLogout_Click);
            // 
            // btCreateAcc
            // 
            this.btCreateAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateAcc.Location = new System.Drawing.Point(1263, 59);
            this.btCreateAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btCreateAcc.Name = "btCreateAcc";
            this.btCreateAcc.Size = new System.Drawing.Size(224, 43);
            this.btCreateAcc.TabIndex = 16;
            this.btCreateAcc.Text = "Create Account";
            this.btCreateAcc.UseVisualStyleBackColor = true;
            this.btCreateAcc.Click += new System.EventHandler(this.btCreateAcc_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(1495, 59);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(214, 43);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Delete Account";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btShelf
            // 
            this.btShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btShelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btShelf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShelf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShelf.ForeColor = System.Drawing.Color.Black;
            this.btShelf.Location = new System.Drawing.Point(29, 191);
            this.btShelf.Margin = new System.Windows.Forms.Padding(4);
            this.btShelf.Name = "btShelf";
            this.btShelf.Size = new System.Drawing.Size(133, 47);
            this.btShelf.TabIndex = 18;
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
            this.lUser.TabIndex = 19;
            this.lUser.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1768, 51);
            this.panel2.TabIndex = 30;
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
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // UserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1768, 909);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.btShelf);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCreateAcc);
            this.Controls.Add(this.btAdminLogout);
            this.Controls.Add(this.btHistory);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.btSales);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.Button btSales;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btAdminLogout;
        private System.Windows.Forms.Button btCreateAcc;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btShelf;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}