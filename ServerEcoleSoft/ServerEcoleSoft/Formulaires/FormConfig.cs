using ServerEcoleSoft.Classes;
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

namespace ServerEcoleSoft.Formulaires
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        String chem;
        void chargercombo()
        {
            //cbodata.Items.Add(Environment.MachineName);
            cbodata.Items.Add(".");
            cbodata.Items.Add("(local)");
            cbodata.Items.Add(@".\SQLEXPRESS");
            cbodata.Items.Add(string.Format(@"{0}", Environment.MachineName));
            cbodata.SelectedIndex = 3;
        }

        void connecter()
        {
            pubCon.dataS = cbodata.Text;
            pubCon.initcat = txtbdd.Text;
            pubCon.id = txtuserId.Text;
            pubCon.pass = txtpass.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbodata.Text.Trim() == "" || txtbdd.Text.Trim() == "" || txtuserId.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Completer tous les champs necessaires SVP", "Champs Obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                connecter();
                chem = "Data Source=" + pubCon.dataS + "; Initial Catalog=" + pubCon.initcat + "; User Id=" + pubCon.id + "; Password=" + pubCon.pass + ";";
                //File.WriteAllText(ClassConstantes.Table.chemin, chem.ToString());
                this.Close();
            }
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            chargercombo();
        }
    }
}
