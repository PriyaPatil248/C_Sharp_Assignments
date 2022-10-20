using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_Student_Mgt_Syst
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=College_Student_Mgt_Syt_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con_Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con_Close();
            }
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure To LOGOUT","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Class.Username;

            // TODO: This line of code loads data into the 'college_Student_Mgt_Syt_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.college_Student_Mgt_Syt_DBDataSet1.Student_Details);

        }
    }
}
