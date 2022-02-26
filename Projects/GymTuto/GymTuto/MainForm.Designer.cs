namespace GymTuto
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.picBxInfo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Controls.Add(this.picBxInfo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(979, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.ForeColor = System.Drawing.Color.Crimson;
            this.btnPayment.Location = new System.Drawing.Point(786, 11);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(155, 41);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(625, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(464, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddMember.BackColor = System.Drawing.Color.White;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddMember.Location = new System.Drawing.Point(303, 11);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(155, 41);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // picBxInfo
            // 
            this.picBxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxInfo.Image = global::GymTuto.Properties.Resources.external_content_duckduckgo;
            this.picBxInfo.Location = new System.Drawing.Point(12, 3);
            this.picBxInfo.Name = "picBxInfo";
            this.picBxInfo.Size = new System.Drawing.Size(100, 59);
            this.picBxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxInfo.TabIndex = 0;
            this.picBxInfo.TabStop = false;
            this.picBxInfo.Click += new System.EventHandler(this.picBxInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(12, 538);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymTuto.Properties.Resources.external_content2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnAddMember;
        private PictureBox picBxInfo;
        private Button btnPayment;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnLogout;
        private Label btnExit;
    }
}