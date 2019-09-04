using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;
using UIProject.Classes;

namespace UIProject.Forms
{
    public partial class ConnectionUser : Form
    {
        DynamicClasses dn = new DynamicClasses();
        InstantRound ir = new InstantRound();
        public ConnectionUser()
        {
            InitializeComponent();
        }
        private void ChargementTontine()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text == "" || passTxt.Text == "" || tontineCombo.Text == "")
                    MessageBox.Show("Veuillez completez tout les champs svp !!!","Erreur de connection",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                {
                    PubCon.testlog = DynamicClasses.GetInstance().loginTest(userTxt.Text, passTxt.Text);
                    ir.Id = dn.retourId("Id", "TRound", "Designation", tontineCombo.Text);

                    if (PubCon.testlog == 1)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ConnectionUser_Load(object sender, EventArgs e)
        {
            dn.chargeCombo(tontineCombo, "Designation", "SELECT_DESIGNATION_ROUND");
        }

        private void tontineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
