namespace InventorySystem
{
    partial class AddProduct
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
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReorder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbProdName
            // 
            this.tbProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdName.Location = new System.Drawing.Point(12, 67);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(184, 24);
            this.tbProdName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(9, 95);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(38, 13);
            this.Brand.TabIndex = 2;
            this.Brand.Text = "Brand:";
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrand.Location = new System.Drawing.Point(12, 111);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(184, 24);
            this.tbBrand.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category:";
            // 
            // tbReorder
            // 
            this.tbReorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReorder.Location = new System.Drawing.Point(12, 308);
            this.tbReorder.Name = "tbReorder";
            this.tbReorder.Size = new System.Drawing.Size(184, 24);
            this.tbReorder.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reorder Level:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(12, 258);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(184, 24);
            this.tbQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(12, 206);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(184, 24);
            this.tbPrice.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expiration Date:";
            // 
            // dtExpiration
            // 
            this.dtExpiration.Location = new System.Drawing.Point(15, 366);
            this.dtExpiration.MinDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(181, 20);
            this.dtExpiration.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Add Product";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(13, 395);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(76, 33);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "SAVE";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(123, 395);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(74, 33);
            this.btClear.TabIndex = 20;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Bread",
            "Beverage",
            "Canned Goods",
            "Condiment",
            "Cleaning and Laundry",
            "Dairy",
            "Hygene",
            "Frozen Foods",
            "Liquor",
            "Snack"});
            this.cbCategory.Location = new System.Drawing.Point(15, 161);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(181, 24);
            this.cbCategory.TabIndex = 21;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 451);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtExpiration);
            this.Controls.Add(this.tbReorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProdName);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}