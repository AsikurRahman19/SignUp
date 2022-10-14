namespace SignUp
{
    partial class FrmLogin
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
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(336, 195);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbPassword.Multiline = true;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(358, 56);
            this.TbPassword.TabIndex = 25;
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(336, 99);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbUsername.Multiline = true;
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(358, 49);
            this.TbUsername.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Location = new System.Drawing.Point(409, 280);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(232, 72);
            this.BtnLogin.TabIndex = 21;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbPassword;
        private TextBox TbUsername;
        private Label label2;
        private Label label1;
        private Button BtnLogin;
    }
}