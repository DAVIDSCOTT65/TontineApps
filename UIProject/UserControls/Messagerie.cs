using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscriptionLib;
using TontineUtilities;
using UIProject.Classes;
using UIProject.Forms;

namespace UIProject.UserControls
{
    public partial class Messagerie : UserControl
    {
        public Messagerie()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Messagerie_Load(object sender, EventArgs e)
        {
            
            radioMembre.Checked = true;
            
        }
        void RefreshDatas(IInscription insc)
        {
            if (radioAgent.Checked == true)
            {
                dgInscit.DataSource = insc.AllAgent();
            }
            else if (radioMembre.Checked == true)
            {
                dgInscit.DataSource = insc.AllInscriptionsRound(InstantRound.GetInstance().Id);
            }
                
        }

        private void radioEtudiant_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDatas(new Inscription());
        }
        void ClicGrid()
        {
            try
            {
                int i;
                i = dgInscit.CurrentRow.Index;

                txtnumero.Text = dgInscit["ContactCol", i].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }

        private void dgInscit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClicGrid();
        }
        void Search(IInscription cot)
        {
            dgInscit.DataSource = cot.Research(serchTxt.Text);
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new Inscription());
        }

        private void radio_tous_CheckedChanged(object sender, EventArgs e)
        {
            txtnumero.Enabled = false;
        }

        private void radio_choix_CheckedChanged(object sender, EventArgs e)
        {
            txtnumero.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Envoyer();
        }
        void Envoyer()
        {
            if (radio_choix.Checked == true)
            {
                if (txtnumero.Text == "" || txtmessage.Text == "")
                {
                    MessageBox.Show("Completez le numero et le message svp !!!", "Message de confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    EnvoieMessage(txtnumero.Text, txtmessage.Text);
                    MessageBox.Show("Envoie réussi ", "Message de confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radio_tous.Checked == true)
            {
                if (txtmessage.Text != "")
                {
                    for (int i = 0; i < dgInscit.Rows.Count; i++)
                    {
                        string numero = dgInscit[11, i].Value.ToString();
                        EnvoieMessage(numero, txtmessage.Text);
                    }
                    MessageBox.Show("Envoie envoyées avec succes", "Message de confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completez le message svp !!!", "Message de confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        void EnvoieMessage(string numero, string message)
        {
            ClsSMS sms = new ClsSMS();
            sms.NumeroTutaire1 = numero;
            sms.CorpsMessage1 = message;
            sms.EtatSms1 = 0;
            sms.Utilisateur1 = UserSession.GetInstance().UserName;
            DynamicClasses.GetInstance().insert_Messagerie(sms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            txtmessage.Text = "";
            FrmEnvoieSMS frm = new FrmEnvoieSMS();
            frm.ShowDialog();
            
        }
    }
}
