using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoundLib;
using TontineUtilities;

namespace UIProject.UserControls
{
    public partial class UC_Round : UserControl
    {
        int idRound = 0;
        int idDetail = 0;
        bool gridClic;
        public UC_Round()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgManyCotisation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().AccessLevel != "1")
            {
                MessageBox.Show("Vous ne pouvez pas effectuer d'opération ici, seul les administrateurs le peuvent", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                SaveRound();
        }
        void NewIdRound()
        {
            Round rd = new Round();

            idRound = rd.Nouveau();
        }
        void SaveRound()
        {
            try
            {
                NewIdRound();

                if (idRound==0 || idDetail==0 || designationTxt.Text=="" || dateTxt.Text=="")
                {
                    MessageBox.Show("Enregistrement impossible, il ne doit pas y avoir des champs vide");
                }
                else
                {
                    Round rd = new Round();

                    rd.Id = idRound;
                    rd.Designation = designationTxt.Text;
                    rd.Date_Debut = Convert.ToDateTime(dateTxt.Text);
                    rd.RefDetail = idDetail;

                    rd.Enregistrer(rd);
                    RefreshData(new Details_Round());
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void NewIdDetailRound()
        {
            Details_Round dr = new Details_Round();

            idDetail = dr.Nouveau();
        }
        void SaveDetail()
        {
            try
            {
                NewIdDetailRound();

                if (idDetail==0 || ecartTxt.Text=="" || montTxt.Text == "" || deviseTxt.Text=="" || nbrMax.Text=="")
                {
                    MessageBox.Show("Enregistrement impossible, il ne doit pas y avoir des champs vide");
                }
                else
                {
                    if(Convert.ToInt32(ecartTxt.Text)<=0 || Convert.ToInt32(montTxt.Text)<=0 || Convert.ToInt32(nbrMax.Text)<=0)
                        MessageBox.Show("Enregistrement impossible, il y a des champs qui possède de valeur inférieur ou egal à zéro");
                    else
                    {
                        Details_Round dr = new Details_Round();

                        dr.Id = idDetail;
                        dr.Ecart_Jour = Convert.ToInt32(ecartTxt.Text);
                        dr.Montant_Jour = Convert.ToDecimal(montTxt.Text);
                        dr.Devise = deviseTxt.Text;
                        dr.Limite = Convert.ToInt32(nbrMax.Text);
                        dr.UserSession = UserSession.GetInstance().UserName;

                        dr.Enregistrer(dr);

                        RefreshData(new Details_Round());
                    }
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().AccessLevel != "4")
            {
                MessageBox.Show("Vous ne pouvez pas effectuer d'opération ici, seul les administrateurs le peuvent","Attention",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
                SaveDetail();
            
        }

        private void UC_Round_Load(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().AccessLevel != "4")
            {
                niveauLbl.Visible = true;
            }
            RefreshData(new Details_Round());
        }
        void RefreshData(Details_Round rd)
        {
            dgRound.DataSource = rd.AllDetailsRounds();
            dgDetail.DataSource = rd.AllDetails();
        }
        void clic_gridDetail()
        {
            gridClic = true;
            idRound = 0;
            idDetail = 0;
            try
            {
                int i;
                i = dgDetail.CurrentRow.Index;


                idDetail = Convert.ToInt32(dgDetail["ColId", i].Value.ToString());
                ecartTxt.Text = dgDetail["ColEcart", i].Value.ToString();
                montTxt.Text = dgDetail["ColMont", i].Value.ToString();
                deviseTxt.Text = dgDetail["ColDevise", i].Value.ToString();
                nbrMax.Text = dgDetail["ColLimite", i].Value.ToString();
                




            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void clic_gridRound()
        {
            gridClic = true;
            idRound = 0;
            
            try
            {
                int i;
                i = dgDetail.CurrentRow.Index;


                idRound = Convert.ToInt32(dgRound["ColIdRound", i].Value.ToString());
                designationTxt.Text = dgRound["ColDesignation", i].Value.ToString();
                dateTxt.Text = dgRound["ColDatedebut", i].Value.ToString();
               





            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void dgDetail_SelectionChanged(object sender, EventArgs e)
        {
            clic_gridDetail();
        }

        private void dgRound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgRound_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clic_gridRound();
        }
    }
}
