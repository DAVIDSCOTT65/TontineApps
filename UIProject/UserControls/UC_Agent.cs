using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentLib;
using UIProject.Forms;
using UIProject.Classes;
using TontineUtilities;

namespace UIProject.UserControls
{
    public partial class UC_Agent : UserControl
    {
        public UC_Agent()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dgInscit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Agent_Load(object sender, EventArgs e)
        {
            RefreshData(new Agent());
        }
        void loadPhoto(string chamPhoto, string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(chamPhoto, "agent", "idagent", id, pic);
        }
        void clic_grid()
        {
            try
            {
                int i;
                i = dgAgent.CurrentRow.Index;


                //txtid.Text = dataGridView1["ColId", i].Value.ToString();
                lblNom.Text = dgAgent["ColNom", i].Value.ToString();
                lblPhone.Text = dgAgent["ColContact", i].Value.ToString();
                lblMail.Text = dgAgent["ColEmail", i].Value.ToString();
                lblSex.Text = dgAgent["ColSex", i].Value.ToString();
                lblAdress.Text = dgAgent["ColAdresse", i].Value.ToString();
                lblUser.Text = dgAgent["ColPseudo", i].Value.ToString();
                lblPass.Text = dgAgent["ColPassword", i].Value.ToString();
                lblNiveau.Text = dgAgent["ColNiveau", i].Value.ToString();
                lblFonction.Text = dgAgent["ColFonction", i].Value.ToString();
                lblAbilite.Text = dgAgent["ColAbilite", i].Value.ToString();
                lblEtat.Text = dgAgent["ColEtat", i].Value.ToString();

                loadPhoto("photo", dgAgent["ColId", i].Value.ToString(), pictureBox2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void RefreshData(IAgent ag)
        {
            dgAgent.DataSource = ag.AllAgents();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            IAgent ag = new Agent();
            FrmAgent fr = new FrmAgent();
            if (UserSession.GetInstance().Ability == "PSEB")
            {
                fr.lblEtat.Visible = true;
                fr.cmbEtat.Visible = true;
                fr.btnSave.Enabled = true;
            }
            else
            {
                fr.gbNiveau.Enabled = false;
                fr.lblWarning.Visible = true;
                fr.btnSave.Enabled = false;
            }
            fr.idAgent = ag.Nouveau();
            fr.ShowDialog();
            
        }

        private void dgAgent_SelectionChanged(object sender, EventArgs e)
        {
            clic_grid();
        }

        private void dgAgent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }
        void doubleclic_grid()
        {
            try
            {
                FrmAgent frm = new FrmAgent();
                int i;
                i = dgAgent.CurrentRow.Index;

                frm.label1.Text = "Modification info d'un agent";
                frm.idAgent = Convert.ToInt32(dgAgent["ColId", i].Value.ToString());
                frm.nomsTxt.Text = dgAgent["ColNom", i].Value.ToString();
                frm.adresseTxt.Text = dgAgent["ColAdresse", i].Value.ToString();
                frm.emailTxt.Text = dgAgent["ColEmail", i].Value.ToString();
                //label16.Text = dataGridView1["ColSex", i].Value.ToString();
                frm.fonctionTxt.Text = dgAgent["ColFonction", i].Value.ToString();
                frm.userTxt.Text = dgAgent["ColPseudo", i].Value.ToString();
                //frm.passTxt.Text = dgAgent["ColPassword", i].Value.ToString();
                frm.lbl1.Text = dgAgent["ColAbilite", i].Value.ToString();
                frm.fonctionTxt.Text = dgAgent["ColFonction", i].Value.ToString();
                frm.phoneTxt.Text = dgAgent["ColContact", i].Value.ToString();
                frm.lbl1.Visible = true;
                //frm.passTxt.Enabled = false;
                //frm.button1.Enabled = false;
                if (dgAgent["ColSex", i].Value.ToString() == "Masculin")
                {
                    frm.rbtnMasc.Checked = true;
                }
                else
                {
                    frm.rbtnFem.Checked = true;
                }
                if (dgAgent["ColNiveau", i].Value.ToString() == "1")
                {
                    frm.rbtn1.Checked = true;

                }
                else if(dgAgent["ColNiveau", i].Value.ToString() == "2")
                {
                    frm.rbtn2.Checked = true;
                }
                else if (dgAgent["ColNiveau", i].Value.ToString() == "3")
                {
                    frm.rbtn3.Checked = true;
                }
                else if (dgAgent["ColNiveau", i].Value.ToString() == "4")
                {
                    frm.rbtn4.Checked = true;
                }
                if(UserSession.GetInstance().Ability== "PSEB")
                {

                    frm.lblEtat.Visible = true;
                    frm.cmbEtat.Visible = true;
                    frm.gbAgent.Enabled = false;
                    frm.btnParc.Enabled = false;
                    if(UserSession.GetInstance().UserName == dgAgent["ColNom", i].Value.ToString())
                        frm.gbAgent.Enabled = true;

                }
                else
                {
                    frm.gbNiveau.Enabled = false;
                }
                if (UserSession.GetInstance().UserName != dgAgent["ColNom", i].Value.ToString() && UserSession.GetInstance().Ability != "PSEB")
                    frm.btnSave.Enabled = false;
                loadPhoto("photo", dgAgent["ColId", i].Value.ToString(), frm.photo);

                frm.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
