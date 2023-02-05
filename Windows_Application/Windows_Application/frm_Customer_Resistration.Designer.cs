namespace Windows_Application
{
    partial class frm_Customer_Resistration
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
            this.pnl_Customer_Resistration = new System.Windows.Forms.Panel();
            this.lbl_Customer_Resistration = new System.Windows.Forms.Label();
            this.lbl_Reg_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.txt_Reg_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.Reg_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Join_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Customer_Resistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Customer_Resistration
            // 
            this.pnl_Customer_Resistration.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_Customer_Resistration.Controls.Add(this.lbl_Customer_Resistration);
            this.pnl_Customer_Resistration.Location = new System.Drawing.Point(3, 4);
            this.pnl_Customer_Resistration.Name = "pnl_Customer_Resistration";
            this.pnl_Customer_Resistration.Size = new System.Drawing.Size(792, 71);
            this.pnl_Customer_Resistration.TabIndex = 0;
            // 
            // lbl_Customer_Resistration
            // 
            this.lbl_Customer_Resistration.AutoSize = true;
            this.lbl_Customer_Resistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Resistration.Location = new System.Drawing.Point(178, 17);
            this.lbl_Customer_Resistration.Name = "lbl_Customer_Resistration";
            this.lbl_Customer_Resistration.Size = new System.Drawing.Size(355, 39);
            this.lbl_Customer_Resistration.TabIndex = 0;
            this.lbl_Customer_Resistration.Text = "Customer Registration";
            // 
            // lbl_Reg_ID
            // 
            this.lbl_Reg_ID.AutoSize = true;
            this.lbl_Reg_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reg_ID.Location = new System.Drawing.Point(148, 94);
            this.lbl_Reg_ID.Name = "lbl_Reg_ID";
            this.lbl_Reg_ID.Size = new System.Drawing.Size(71, 25);
            this.lbl_Reg_ID.TabIndex = 1;
            this.lbl_Reg_ID.Text = "Reg ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(148, 152);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(64, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(148, 208);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(80, 25);
            this.lbl_Contact.TabIndex = 1;
            this.lbl_Contact.Text = "Contact";
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.Location = new System.Drawing.Point(148, 264);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(95, 25);
            this.lbl_Joining_Date.TabIndex = 1;
            this.lbl_Joining_Date.Text = "Join Date";
            // 
            // txt_Reg_ID
            // 
            this.txt_Reg_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_ID.Location = new System.Drawing.Point(367, 92);
            this.txt_Reg_ID.Name = "txt_Reg_ID";
            this.txt_Reg_ID.Size = new System.Drawing.Size(226, 30);
            this.txt_Reg_ID.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(367, 148);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(226, 30);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.Location = new System.Drawing.Point(366, 203);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(226, 30);
            this.txt_Contact.TabIndex = 3;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "dd/MM/yyyy";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(366, 264);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(225, 20);
            this.dtp_Date.TabIndex = 4;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(66, 306);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(115, 32);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(230, 306);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 32);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(399, 306);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 32);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(588, 306);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 32);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reg_ID,
            this.Name,
            this.Contact,
            this.Join_Date});
            this.dgv_Customer_Details.Location = new System.Drawing.Point(12, 353);
            this.dgv_Customer_Details.MultiSelect = false;
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.ReadOnly = true;
            this.dgv_Customer_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(770, 154);
            this.dgv_Customer_Details.TabIndex = 9;
            this.dgv_Customer_Details.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Customer_Details_MouseClick);
            // 
            // Reg_ID
            // 
            this.Reg_ID.DataPropertyName = "Reg_ID";
            this.Reg_ID.HeaderText = "Reg ID";
            this.Reg_ID.Name = "Reg_ID";
            this.Reg_ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Join_Date
            // 
            this.Join_Date.DataPropertyName = "Join_Date";
            this.Join_Date.HeaderText = "Join Date";
            this.Join_Date.Name = "Join_Date";
            this.Join_Date.ReadOnly = true;
            // 
            // frm_Customer_Resistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 519);
            this.Controls.Add(this.dgv_Customer_Details);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Reg_ID);
            this.Controls.Add(this.lbl_Joining_Date);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Reg_ID);
            this.Controls.Add(this.pnl_Customer_Resistration);
            //this.Name = "frm_Customer_Resistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Resistration";
            this.Load += new System.EventHandler(this.frm_Customer_Resistration_Load);
            this.pnl_Customer_Resistration.ResumeLayout(false);
            this.pnl_Customer_Resistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Customer_Resistration;
        private System.Windows.Forms.Label lbl_Customer_Resistration;
        private System.Windows.Forms.Label lbl_Reg_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.TextBox txt_Reg_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Join_Date;
    }
}