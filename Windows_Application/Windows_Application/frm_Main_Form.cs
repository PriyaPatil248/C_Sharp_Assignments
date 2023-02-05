using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Application
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customer_Resistration frm = new frm_Customer_Resistration();
            frm.Show();
            this.Hide();
        }
    }
}
