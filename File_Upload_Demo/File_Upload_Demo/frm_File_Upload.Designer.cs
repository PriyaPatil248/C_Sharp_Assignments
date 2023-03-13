namespace File_Upload_Demo
{
    partial class frm_File_Upload
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
            this.lbl_File_Upload = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_File_Upload
            // 
            this.lbl_File_Upload.AutoSize = true;
            this.lbl_File_Upload.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_File_Upload.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_File_Upload.Location = new System.Drawing.Point(278, 28);
            this.lbl_File_Upload.Name = "lbl_File_Upload";
            this.lbl_File_Upload.Size = new System.Drawing.Size(214, 40);
            this.lbl_File_Upload.TabIndex = 0;
            this.lbl_File_Upload.Text = "File Upload";
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.Snow;
            this.btn_Upload.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(313, 264);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(111, 49);
            this.btn_Upload.TabIndex = 1;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Snow;
            this.btn_Browse.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(525, 196);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(105, 46);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select File";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileName.ForeColor = System.Drawing.Color.Coral;
            this.lbl_FileName.Location = new System.Drawing.Point(183, 143);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(100, 25);
            this.lbl_FileName.TabIndex = 3;
            this.lbl_FileName.Text = "File Name";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(339, 146);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(150, 30);
            this.tb_Username.TabIndex = 4;
            // 
            // frm_File_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 464);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.lbl_File_Upload);
            this.Name = "frm_File_Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_File_Upload;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox tb_Username;
    }
}

