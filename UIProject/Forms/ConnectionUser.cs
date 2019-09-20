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
using UIProject.UserControls;

namespace UIProject.Forms
{
    public partial class ConnectionUser : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public Principale_Form form1;
        public delegate void Sendata(string text);
        //InstantRound ir = new InstantRound();
        public ConnectionUser()
        {
            InitializeComponent();
            userTxt.Focus();
        }
        public void FundForm1(Principale_Form form1)
        {
            this.form1 = form1;
        }
        void Envoyer()
        {
            Sendata send = new Sendata(form1.FundDataLogin);
            send(UserSession.GetInstance().UserName);
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
                    InstantRound.GetInstance().Id = dn.retourId("Id", "TRound", "Designation", tontineCombo.Text);
                    //Envoyer();
                    if (PubCon.testlog == 1)
                    {
                        this.Close();
                        Principale_Form frm = new Principale_Form();
                        frm.ChargerUser(new UC_Home());
                        //frm.Show();
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
