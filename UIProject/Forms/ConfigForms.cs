using ManageSingleConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;

namespace UIProject.Forms
{
    public partial class ConfigForms : Form
    {
        public ConfigForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        void ChargerServer()
        {
            comboBox2.Items.Add(".");
            comboBox2.Items.Add("local");
            comboBox2.Items.Add(@".\SQLEXPRESS");
            comboBox2.Items.Add(string.Format(@"{0}", Environment.MachineName));
            comboBox2.SelectedIndex = 3;
        }

        private void ConfigForms_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(ConnexionType));
            comboBox1.SelectedIndex = 0;
            ChargerServer();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                   DialogResult result = MessageBox.Show("Are your sure to want to save this configuration ?\n Type Of server : " + comboBox1.Text + "\n Server : " + comboBox2.Text + "\n Database Name : " + textBox1.Text + "\n User : " + textBox2.Text + "\n Password : " + textBox3.Text + " ","Please Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        File.WriteAllText(ClsConstantes.Table.serveur, comboBox2.Text.ToString());
                        File.WriteAllText(ClsConstantes.Table.database, textBox1.Text.ToString());
                        File.WriteAllText(ClsConstantes.Table.user, textBox2.Text.ToString());
                        File.WriteAllText(ClsConstantes.Table.password, textBox3.Text.ToString());
                        ClsGetdatas.GetInstance().Testeconne = 1;
                        this.Close();
                        ClsConnection.GetInstance().connecter();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Completez tous les champ !!!", "Saisie Obligatoire", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
