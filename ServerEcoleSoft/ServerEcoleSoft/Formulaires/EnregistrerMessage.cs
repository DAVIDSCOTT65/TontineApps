using CommunicationSoft.Classes;
using ServerEcoleSoft.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEcoleSoft.Formulaires
{
    public partial class EnregistrerMessage : Form
    {
        public EnregistrerMessage()
        {
            InitializeComponent();
        }

        private void EnregistrerMessage_Load(object sender, EventArgs e)
        {
            GridMessagerie.DataSource = ClsGlossiaires.GetInstance().chargement_Messagerie("Affichage_Details_Inscriptions", "Nom_Complet", "Contact");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_tous.Checked == true)
            {
                envoiPlusieur();
            }
            else if (radio_choix.Checked == true)
            {
                EnvoiPersonne();
            }
        }



        void envoiPlusieur()
        {
            try
            {
                string touNum;

                if (MStexte.Text.Length >= 140)
                {
                    for (int i = 0; i < (GridMessagerie.Rows.Count) - 1; i++)
                    {
                        touNum = GridMessagerie[1, i].Value.ToString();
                        sendMessages(touNum, MStexte.Text);
                    }
                }
                else
                {
                    for (int i = 0; i < (GridMessagerie.Rows.Count) - 1; i++)
                    {
                        touNum = GridMessagerie[1, i].Value.ToString();
                        sendMessages(touNum, MStexte.Text);
                        //m.sendshortMsg(touNum, MStexte.Text);
                    }
                }

                MessageBox.Show("Message envoye avec succe !!!", "Reussite", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'envoie !!!", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        void sendMessages(string num, string msgText)
        {
            ClsSMS sms = new ClsSMS();
            sms.Numero = num;
            sms.CorpsMsg = msgText;
            sms.DateEnvoie = DateTime.Now;
            sms.EtatSMS = 0;
            sms.User = "Sik";
            ClsGlossiaires.GetInstance().insert_SMS(sms);
        }

        void EnvoiPersonne()
        {
            try
            {
                if (MStexte.Text.Length > 140)
                {
                    sendMessages(Numtext.Text, MStexte.Text);
                }
                else
                {
                    sendMessages(Numtext.Text, MStexte.Text);
                }

                MessageBox.Show("Message envoye avec succe !!!", "Reussite", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Echec d'envoie !!!", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridMessagerie.DataSource = ClsGlossiaires.GetInstance().chargement_Messagerie("tPersonnel", "customer_name", "contact",textBox1);
        }

        private void GridMessagerie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = GridMessagerie.CurrentRow.Index;
                Numtext.Text = GridMessagerie[1, i].Value.ToString();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GridMessagerie.DataSource = ClsGlossiaires.GetInstance().chargement_Messagerie1("tPersonnel", "customer_name", "contact", textBox1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GridMessagerie.DataSource = ClsGlossiaires.GetInstance().chargement_Messagerie2("tPersonnel", "customer_name", "contact", textBox1);
        }
    }
}
