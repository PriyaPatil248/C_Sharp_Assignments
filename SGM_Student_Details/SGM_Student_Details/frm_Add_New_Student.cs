using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Details
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_Details_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar ==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) ))
            {
                e.Handled=true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text !="" && tb_Name.Text !="" && tb_Mobile_No.Text !="" && tb_Mobile_No.TextLength==10 && cmb_Course.Text !="")
            {

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details (Roll_No, Name, DOB, Mobile_No, Course) values(@RNo, @Nm, @DOB, @MNo, @Course)";

                Cmd.Parameters.Add("RNo",SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Record Insertead  Successfuly","Success", MessageBoxButtons.OK , MessageBoxIcon.Information);

                tb_Roll_No.Clear();
                tb_Name.Clear();
                dtp_DOB.Text = "1/1/2005";
                tb_Mobile_No.Clear();
                cmb_Course.SelectedIndex = -1;



            }
            else
            {
                MessageBox.Show("First Fill All Cumpulsary fields ","Failed",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Con_Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }



        private void btn_Log_Out_Click_1(object sender, EventArgs e)
        {
            frm_SGM_Student_Login obj = new frm_SGM_Student_Login();
            obj.Show();
            this.Hide();
        }

        
       
    }
}
