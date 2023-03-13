using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_Upload_Demo
{
    public partial class frm_File_Upload : Form
    {
        public frm_File_Upload()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Files(*pdf;)|*.pdf;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_FileName.Text = openFileDialog1.FileName;
            }
        }


        private void btn_Upload_Click(object sender, EventArgs e)
        {
            string strNewPath = @"D:\File_Upload_Project\" + tb_Username.Text + ".pdf";
            string strOldPath = openFileDialog1.FileName;

            File.Copy(strOldPath,strNewPath,true);
            MessageBox.Show("File Uploaded successfully...");

            tb_Username.Clear();
            lbl_FileName.Text = "FileName";
            openFileDialog1.Reset();
        }
    }
}
