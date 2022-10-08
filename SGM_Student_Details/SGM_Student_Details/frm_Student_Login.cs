using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Details
{
    public partial class frm_SGM_Student_Login : Form
    {
        public frm_SGM_Student_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (((tb_Username.Text == "a") && (tb_Password.Text == "a123")) || (tb_Username.Text == "b") && (tb_Password.Text == "b123") || (tb_Username.Text == "c") && (tb_Password.Text == "#"))
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username and Password";
                lbl_Error.ForeColor = Color.OrangeRed;
            }

            tb_Username.Clear();
            tb_Password.Clear();
        }

      
    }
}
