namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.moviesDGV = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DGVWatchers = new System.Windows.Forms.DataGridView();
            this.btnAddW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWatchers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // moviesDGV
            // 
            this.moviesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDGV.Location = new System.Drawing.Point(211, 67);
            this.moviesDGV.Name = "moviesDGV";
            this.moviesDGV.RowTemplate.Height = 25;
            this.moviesDGV.Size = new System.Drawing.Size(204, 278);
            this.moviesDGV.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(396, 376);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DGVWatchers
            // 
            this.DGVWatchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWatchers.Location = new System.Drawing.Point(563, 67);
            this.DGVWatchers.Name = "DGVWatchers";
            this.DGVWatchers.RowTemplate.Height = 25;
            this.DGVWatchers.Size = new System.Drawing.Size(204, 278);
            this.DGVWatchers.TabIndex = 4;
            // 
            // btnAddW
            // 
            this.btnAddW.Location = new System.Drawing.Point(461, 248);
            this.btnAddW.Name = "btnAddW";
            this.btnAddW.Size = new System.Drawing.Size(75, 23);
            this.btnAddW.TabIndex = 3;
            this.btnAddW.Text = "Add";
            this.btnAddW.UseVisualStyleBackColor = true;
            this.btnAddW.Click += new System.EventHandler(this.btnAddW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVWatchers);
            this.Controls.Add(this.btnAddW);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.moviesDGV);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moviesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWatchers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdd;
        private DataGridView moviesDGV;
        private Button btnRefresh;
        private DataGridView DGVWatchers;
        private Button btnAddW;
    }
}