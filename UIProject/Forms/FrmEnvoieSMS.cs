using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;

namespace UIProject.Forms
{
    public partial class FrmEnvoieSMS : Form
    {
        public FrmEnvoieSMS()
        {
            InitializeComponent();
        }

        private void FrmEnvoieSMS_Load(object sender, EventArgs e)
        {
            GetAllPorts(cboPort);
            Refresh(new ClsSMS());

        }
        void Refresh(ClsSMS sms)
        {
            dgSms.DataSource = sms.AllSms();
        }
        public string GetAllPorts(ComboBox combo)
        {
            //string MODEMS = "";
            string modems = "";

            try
            {
                //combo.Items.Clear();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem ");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if ((string)queryObj["Status"] == "OK")
                    {

                        combo.Items.Add(queryObj["AttachedTo"] + " - " + System.Convert.ToString(queryObj["Description"]));
                    }
                    if (combo.Items.Count > 0)
                    {
                        combo.SelectedIndex = 0;
                    }
                }

                return modems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la requette", "Erreur de" + ex.Message);
                return "";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
