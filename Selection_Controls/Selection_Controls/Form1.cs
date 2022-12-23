using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Selection_Controls
{
    public partial class frm_Selection_Controls : Form
    {
        public frm_Selection_Controls()
        {
            InitializeComponent();
        }

        private void btn_Show_Output_Click(object sender, EventArgs e)
        {
            string Output = "";

            if (tb_Student_Name.Text != "" && (rb_Male.Checked == true || rb_Female.Checked == true) && (rb_Morning.Checked == true || rb_Afternoon.Checked == true || rb_Evening.Checked == true))
            {
                lbl_Error1.Visible = false;
                lbl_Error2.Visible = false;
                lbl_Error3.Visible = false;
            }

            if (tb_Student_Name.Text != "")
            {
                if (rb_Female.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Female.Text + ",";
                }
                else if (rb_Male.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Male.Text + ",";
                }
                else
                {
                    lbl_Error2.Text = "Select Gender";
                    lbl_Error2.Visible = true;
                }
            }
            else
            {
                lbl_Error1.Text = "Fill Student Name";
                lbl_Error1.Visible = true;
            }

            if (rb_Morning.Checked == true)
            {
                Output += " wants batch time at " + rb_Morning.Text + ".";
            }
            else if (rb_Afternoon.Checked == true)
            {
                Output += " wants batch time at " + rb_Afternoon.Text + ".";
            }
            else if (rb_Evening.Checked == true)
            {
                Output += " wants batch time at " + rb_Evening.Text + ".";
            }
            else
            {
                lbl_Error3.Text = "Select Preferd Batch Time";
                lbl_Error3.Visible = true;
            }

            tb_Show_Output.Text = Output;
        }

        private void btn_Show_Technical_Skills_Click(object sender, EventArgs e)
        {
            string Prog = tb_Student_Name.Text + " Knows ";

            if (cb_C.Checked == true)
            {
                if (cb_Cpp.Checked == false && cb_C_Sharp.Checked == false && cb_Java.Checked == false)
                {
                    Prog += " " + cb_C.Text + ".";
                }
                else
                {
                    Prog += "" + cb_C.Text + ",";
                }
            }
            if (cb_Cpp.Checked == true)
            {
                if (cb_C_Sharp.Checked == false && cb_Java.Checked == false)
                {
                    Prog += " " + cb_Cpp.Text + ".";
                }
                else
                {
                    Prog += " " + cb_Cpp.Text + ",";
                }
            }
            if (cb_C_Sharp.Checked == true)
            {
                if (cb_Java.Checked == false)
                {
                    Prog +=" " + cb_C_Sharp.Text + ".";
                }
                else
                {
                    Prog += " " + cb_C_Sharp.Text + ",";
                }
            }
            if (cb_Java.Checked == true)
            {
                Prog += " " + cb_Java.Text + ".";
            }

            if (cb_C.Checked == false && cb_Cpp.Checked == false && cb_C_Sharp.Checked == false && cb_Java.Checked == false)
            {
                Prog = tb_Student_Name.Text + " Dont Have Knowledge of Any programming Skills";
            }

            if (rb_Female.Checked == true)
            {
                Prog += " And She Wants To Be ";
            }
            else if (rb_Male.Checked == true)
            {
                Prog += " And He Wants To Be ";
            }
            else
            {
                Prog += " Wants To Be ";
            }

            for (int i = 0; i <= (clb_Choices.Items.Count - 1); i++)
            {
                if (clb_Choices.GetItemChecked(i))
                {
                    Prog += " " + clb_Choices.Items[i].ToString();
                }
            }

            tb_Show_Technical_Skills.Text = Prog;
        }
    }
}
