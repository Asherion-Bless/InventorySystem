namespace InventorySystem
{
    partial class SalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvSR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSR)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sales Report\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reporting TimeFrame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "From:";
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(1171, 141);
            this.btnP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(309, 68);
            this.btnP.TabIndex = 14;
            this.btnP.Text = "Print Report";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(856, 141);
            this.btnG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(309, 68);
            this.btnG.TabIndex = 13;
            this.btnG.Text = "Generate Report";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "\" \"";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(319, 187);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(217, 38);
            this.dtpTo.TabIndex = 12;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "\" \"";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(319, 143);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(217, 38);
            this.dtpFrom.TabIndex = 11;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dgvSR
            // 
            this.dgvSR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSR.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSR.Location = new System.Drawing.Point(21, 239);
            this.dgvSR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSR.Name = "dgvSR";
            this.dgvSR.RowTemplate.Height = 24;
            this.dgvSR.Size = new System.Drawing.Size(1545, 505);
            this.dgvSR.TabIndex = 17;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 769);
            this.Controls.Add(this.dgvSR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesReport";
            this.Text = "GenerateSales";
            this.Load += new System.EventHandler(this.SalesReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dgvSR;
    }
}