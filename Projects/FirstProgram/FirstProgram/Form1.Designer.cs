namespace FirstProgram
{
    partial class LoginPage
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_underTitle = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtBox_usr = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.btn_passUnhide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(116, 192);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(176, 35);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(12, 192);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(98, 35);
            this.btn_Restart.TabIndex = 1;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usr.Location = new System.Drawing.Point(24, 92);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(82, 16);
            this.lbl_usr.TabIndex = 4;
            this.lbl_usr.Text = "Username:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("MS Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(56, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(205, 24);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Welcome to the \r\n";
            // 
            // btn_underTitle
            // 
            this.btn_underTitle.AutoSize = true;
            this.btn_underTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underTitle.Location = new System.Drawing.Point(80, 37);
            this.btn_underTitle.Name = "btn_underTitle";
            this.btn_underTitle.Size = new System.Drawing.Size(151, 29);
            this.btn_underTitle.TabIndex = 7;
            this.btn_underTitle.Text = "PasSecurity";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(24, 137);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(79, 16);
            this.lbl_pass.TabIndex = 9;
            this.lbl_pass.Text = "Password:";
            // 
            // txtBox_usr
            // 
            this.txtBox_usr.Location = new System.Drawing.Point(112, 92);
            this.txtBox_usr.Name = "txtBox_usr";
            this.txtBox_usr.Size = new System.Drawing.Size(168, 20);
            this.txtBox_usr.TabIndex = 10;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Location = new System.Drawing.Point(112, 136);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(168, 20);
            this.txtBox_pass.TabIndex = 11;
            this.txtBox_pass.UseSystemPasswordChar = true;
            // 
            // btn_passUnhide
            // 
            this.btn_passUnhide.Location = new System.Drawing.Point(283, 137);
            this.btn_passUnhide.Name = "btn_passUnhide";
            this.btn_passUnhide.Size = new System.Drawing.Size(18, 19);
            this.btn_passUnhide.TabIndex = 12;
            this.btn_passUnhide.UseVisualStyleBackColor = true;
            this.btn_passUnhide.Click += new System.EventHandler(this.btn_passUnhide_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 238);
            this.Controls.Add(this.btn_passUnhide);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.txtBox_usr);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.btn_underTitle);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_usr);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label btn_underTitle;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtBox_usr;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.Button btn_passUnhide;
    }
}

