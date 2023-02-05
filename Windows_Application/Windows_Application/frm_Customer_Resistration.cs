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
    public partial class frm_Customer_Resistration : Form
    {
        Connection_Database db = new Connection_Database();
        public frm_Customer_Resistration()
        {
            InitializeComponent();
        }

        private void frm_Customer_Resistration_Load(object sender, EventArgs e)
        {
            Cleardata();
            btn_New.Focus();
            EnabledFalse();
            db.FillGrideData(dgv_Customer_Details,"Select * from Customer_Details");
        }

        void GetmaxID()
        {
            txt_Reg_ID.Text = db.GetAutoID("Select Max(Reg_ID)from Customer_Details").ToString();
        }



        private void btn_New_Click(object sender, EventArgs e)
        {
            Cleardata();
            txt_Name.Focus();
            GetmaxID();

            btn_Save.Enabled = true;
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            db.ExecuteSqlQuery("Insert into Customer_Details(Reg_ID,Name,Contact,Join_Date)Values('" + txt_Reg_ID.Text+ "','" + txt_Name.Text +"','" + txt_Contact.Text + "','" + dtp_Date.Value.ToString("dd/MM/yyyy") + "')");
            db.FillGrideData(dgv_Customer_Details, "Select * from Customer_Details");
            EnabledFalse();
            Cleardata();
            btn_New.Focus();
            MessageBox.Show("Record Saved Successfully...");
        }

        void EnabledFalse()
        {
            btn_Save.Enabled = false;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }

        void Cleardata()
        {
            txt_Reg_ID.Clear();
            txt_Name.Clear();
            txt_Contact.Clear();
        }

        private void dgv_Customer_Details_MouseClick(object sender, MouseEventArgs e)
        {
            GridDataDis();
        }

        void GridDataDis()
        {
            try
            {
                txt_Reg_ID.Text = dgv_Customer_Details.SelectedRows[0].Cells["Reg_ID"].Value.ToString();
                txt_Name.Text = dgv_Customer_Details.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_Contact.Text = dgv_Customer_Details.SelectedRows[0].Cells["Contact"].Value.ToString();
                dtp_Date.Value = DateTime.Parse(dgv_Customer_Details.SelectedRows[0].Cells["Join_Date"].Value.ToString());

                EnabledFalse();
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
                txt_Name.Focus();
            }

            catch { }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {


            db.ExecuteSqlQuery("Update Customer_Details SET Name = '" +txt_Name.Text + "', Contact='" +txt_Contact.Text +"', Join_Date='" + dtp_Date.Value.ToString("dd/MM/yyyy")+ "' Where Reg_ID='" + txt_Reg_ID.Text+"'");
            db.FillGrideData(dgv_Customer_Details,"Select * from Customer_Details");
            EnabledFalse();
            btn_New.Focus();
            MessageBox.Show("Record Updated Succesfully....");
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from Customer_Details where Reg_ID="+txt_Reg_ID.Text);
            
            }

            db.FillGrideData(dgv_Customer_Details, "Select * from Customer_Details");
            EnabledFalse();
            btn_New.Focus();
            MessageBox.Show("Delete Data Successfully");
        }
    }
}
