using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject.Forms
{
    public partial class FrmAgent : Form
    {
        public FrmAgent()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
                gbNiveau1.Enabled = true;
            else
            {
                gbNiveau1.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
                
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn2.Checked == true)
                gbNiveau2.Enabled = true;
            else
            {
                gbNiveau2.Enabled = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
                
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn3.Checked == true)
                gbNiveau3.Enabled = true;
            else
            {
                gbNiveau3.Enabled = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
                
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn4.Checked == true)
                gbNiveau4.Enabled = true;
            else
            {
                gbNiveau4.Enabled = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                lbl1.Visible = true;
                lbl1.Text = "V";
            }
                
            else
            {
                lbl1.Text = "";
                lbl1.Visible = false;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
                
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                lbl1.Visible = true;
                checkBox2.Checked = true;
                lbl1.Text = "VS";
            }
                
            else
            {
                checkBox1.Checked = false;
                lbl1.Text = "V";
            }
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                lbl1.Visible = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                lbl1.Text = "VSI";
            }
                
            else
                lbl1.Text = "VS";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                lbl1.Visible = true;
                lbl1.Text = "V";
            }

            else
            {
                lbl1.Text = "";
                lbl1.Visible = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                lbl1.Visible = true;
                checkBox6.Checked = true;
                lbl1.Text = "VC";
            }

            else
            {
                checkBox4.Checked = false;
                lbl1.Text = "V";
            }
                
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                lbl1.Visible = true;
                checkBox6.Checked = true;
                checkBox5.Checked = true;
                lbl1.Text = "VSR";
            }

            else
                lbl1.Text = "VS";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                lbl1.Visible = true;
                lbl1.Text = "V";
            }

            else
            {
                lbl1.Text = "";
                lbl1.Visible = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                lbl1.Visible = true;
                checkBox9.Checked = true;
                lbl1.Text = "VS";
            }

            else
            {
                checkBox8.Checked = false;
                checkBox10.Checked = false;
                lbl1.Text = "V";

            }
                
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                lbl1.Visible = true;
                checkBox7.Checked = true;
                checkBox9.Checked = true;
                lbl1.Text = "VST";
            }

            else
            {
                checkBox8.Checked = false;
                
                lbl1.Text = "VS";
            }
                
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                lbl1.Visible = true;
                checkBox7.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
                lbl1.Text = "VSTR";
            }

            else
                lbl1.Text = "VST";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                lbl1.Visible = true;
                lbl1.Text = "P";
            }

            else
            {
                lbl1.Text = "";
                lbl1.Visible = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                lbl1.Visible = true;
                checkBox14.Checked = true;
                lbl1.Text = "PS";
            }

            else
            {
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                lbl1.Text = "P";
            }
                
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                lbl1.Visible = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true;
                lbl1.Text = "PSE";
            }

            else
            {
                
                checkBox12.Checked = false;
                lbl1.Text = "PS";
            }
                
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                lbl1.Visible = true;
                checkBox11.Checked = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true;
                lbl1.Text = "PSEB";
            }

            else
                lbl1.Text = "PSE";
        }
    }
}
