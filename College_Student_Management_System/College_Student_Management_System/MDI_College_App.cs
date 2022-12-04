using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace College_Student_Management_System
{
    public partial class MDI_College_App : Form
    {
        public MDI_College_App()
        {
            InitializeComponent();
        }


        private void MDI_College_App_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = "Welcome" + Shared_Class.Username;

            if (Shared_Class.Username != "Admin")
            {
                courseToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
                addToolStripMenuItem.Visible = false;
            }
        }


        private void AddNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.MdiParent = this;

            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            //Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Obj.Text = String.Empty;
        }

        private void searchSingalStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
        }

        private void viewAllStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List Obj = new frm_View_All_Student_List();

            Obj.MdiParent = this;
            Obj.Show();
            Obj.WindowState = FormWindowState.Maximized;
            Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Obj.Text = String.Empty;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            College_Student_Management_System.frm_Add_New_Course Obj = new College_Student_Management_System.frm_Add_New_Course();

            Obj.MdiParent = this;
            Obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void clculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
       

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Shour You Want To Log Out???","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
