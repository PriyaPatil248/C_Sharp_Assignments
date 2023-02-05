using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_Application
{
    public partial class frm_Login : Form
    {
        Connection_Database db;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            db = new Connection_Database();
            db.FillCombo(cmb_Username,"Select * from Login_Tlb", "Username", "User_Type");
            cmb_Username.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GettableData("Select * from Login_Tlb where Username ='" + cmb_Username.Text + "'AND Password = '" + txt_Password.Text + "'");
            if(dt.Rows.Count >= 1)
            {
                if(dt.Rows[0]["User_Type"].ToString().Equals("Admin"))
                {
                    frm_Main_Form frm = new frm_Main_Form();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid username and password !...");
            }
        }
    }
}
