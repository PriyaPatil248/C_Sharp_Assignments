using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_Student_Management_System
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=College_Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();

            tb_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_No=@RNo",Con);

            Cmd.Parameters.Add("RNo",SqlDbType.Int).Value=tb_Roll_No.Text;
            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                cmb_Course.Text = (Dr["DOB"].ToString());

                tb_Name.Enabled = true;
                tb_Mobile_No.Enabled = true;
                cmb_Course.Enabled = true;
                dtp_DOB.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Record Found","Invalid Roll No");
                tb_Roll_No.Clear();
            }

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text="01/01/2005";
            cmb_Course.ResetText();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
