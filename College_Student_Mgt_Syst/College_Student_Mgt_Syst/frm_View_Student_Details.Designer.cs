namespace College_Student_Mgt_Syst
{
    partial class frm_View_Student_Details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Student_Details));
            this.lbl_View_Student_Details = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.college_Student_Mgt_Syt_DBDataSet1 = new College_Student_Mgt_Syst.College_Student_Mgt_Syt_DBDataSet1();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new College_Student_Mgt_Syst.College_Student_Mgt_Syt_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.college_Student_Mgt_Syt_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_Details
            // 
            this.lbl_View_Student_Details.AutoSize = true;
            this.lbl_View_Student_Details.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_View_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_Details.Location = new System.Drawing.Point(212, 19);
            this.lbl_View_Student_Details.Name = "lbl_View_Student_Details";
            this.lbl_View_Student_Details.Size = new System.Drawing.Size(332, 39);
            this.lbl_View_Student_Details.TabIndex = 0;
            this.lbl_View_Student_Details.Text = "View Student Details";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(658, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(124, 49);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(445, 455);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(259, 40);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(21, 79);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.Size = new System.Drawing.Size(736, 370);
            this.dgv_Student_List.TabIndex = 3;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.college_Student_Mgt_Syt_DBDataSet1;
            // 
            // college_Student_Mgt_Syt_DBDataSet1
            // 
            this.college_Student_Mgt_Syt_DBDataSet1.DataSetName = "College_Student_Mgt_Syt_DBDataSet1";
            this.college_Student_Mgt_Syt_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_UName.Location = new System.Drawing.Point(12, 12);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(124, 29);
            this.lbl_UName.TabIndex = 4;
            this.lbl_UName.Text = "Username";
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.Lime;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(47, 456);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(305, 39);
            this.btn_Search_Student_Details.TabIndex = 2;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_View_Student_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.college_Student_Mgt_Syt_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Label lbl_UName;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private College_Student_Mgt_Syt_DBDataSet1 college_Student_Mgt_Syt_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private College_Student_Mgt_Syt_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}