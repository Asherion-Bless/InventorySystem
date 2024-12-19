namespace InventorySystem
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.pTB = new System.Windows.Forms.Panel();
            this.pTB2 = new System.Windows.Forms.Panel();
            this.pPanelBg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lLogIn = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pPanelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.BackColor = System.Drawing.Color.DimGray;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(64, 342);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ShortcutsEnabled = false;
            this.tbUsername.Size = new System.Drawing.Size(564, 42);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TabStop = false;
            this.tbUsername.Tag = "";
            this.tbUsername.Text = "Username";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.BackColor = System.Drawing.Color.DimGray;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(64, 444);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(564, 42);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TabStop = false;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(243, 566);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(201, 81);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pTB
            // 
            this.pTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pTB.BackColor = System.Drawing.Color.White;
            this.pTB.Location = new System.Drawing.Point(64, 384);
            this.pTB.Margin = new System.Windows.Forms.Padding(4);
            this.pTB.Name = "pTB";
            this.pTB.Size = new System.Drawing.Size(564, 6);
            this.pTB.TabIndex = 4;
            // 
            // pTB2
            // 
            this.pTB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pTB2.BackColor = System.Drawing.Color.White;
            this.pTB2.Location = new System.Drawing.Point(64, 486);
            this.pTB2.Margin = new System.Windows.Forms.Padding(4);
            this.pTB2.Name = "pTB2";
            this.pTB2.Size = new System.Drawing.Size(564, 6);
            this.pTB2.TabIndex = 5;
            // 
            // pPanelBg
            // 
            this.pPanelBg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPanelBg.BackColor = System.Drawing.Color.DimGray;
            this.pPanelBg.Controls.Add(this.pbSearch);
            this.pPanelBg.Controls.Add(this.label1);
            this.pPanelBg.Controls.Add(this.lLogIn);
            this.pPanelBg.Controls.Add(this.pTB2);
            this.pPanelBg.Controls.Add(this.tbPassword);
            this.pPanelBg.Controls.Add(this.btLogin);
            this.pPanelBg.Controls.Add(this.pTB);
            this.pPanelBg.Controls.Add(this.tbUsername);
            this.pPanelBg.Location = new System.Drawing.Point(298, 53);
            this.pPanelBg.Margin = new System.Windows.Forms.Padding(4);
            this.pPanelBg.Name = "pPanelBg";
            this.pPanelBg.Size = new System.Drawing.Size(692, 719);
            this.pPanelBg.TabIndex = 6;
            this.pPanelBg.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Management System";
            // 
            // lLogIn
            // 
            this.lLogIn.AutoSize = true;
            this.lLogIn.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogIn.ForeColor = System.Drawing.Color.White;
            this.lLogIn.Location = new System.Drawing.Point(257, 193);
            this.lLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLogIn.Name = "lLogIn";
            this.lLogIn.Size = new System.Drawing.Size(177, 67);
            this.lLogIn.TabIndex = 6;
            this.lLogIn.Text = "LogIn";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(289, 19);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(103, 85);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 8;
            this.pbSearch.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(272, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 759);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1258, 867);
            this.Controls.Add(this.pPanelBg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.pPanelBg.ResumeLayout(false);
            this.pPanelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel pTB;
        private System.Windows.Forms.Panel pTB2;
        private System.Windows.Forms.Panel pPanelBg;
        private System.Windows.Forms.Label lLogIn;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Panel panel1;
    }
}