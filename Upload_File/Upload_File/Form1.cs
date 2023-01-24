using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Upload_File
{
    public partial class frm_Upload_File : Form
    {
        public frm_Upload_File()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Upload_File_DB;Integrated Security=True");
        private void frm_Upload_File_Load(object sender, EventArgs e)
        {

        }

        private void btn_Browse_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";

            openFileDialog1.Title = "Select File to Upload.";

            openFileDialog1.Filter = "Select valid Document(*.pdf; *.xlsx; *.html) |*.pdf; *.docx; *.xlsx; *.html";

            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        lbl_directory_path.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Upload_Document_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into doc (document)values('\\Document\\" + filename + "')", con);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Document Uploaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
