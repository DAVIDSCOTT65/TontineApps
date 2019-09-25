using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIProject.Classes;
using RemboursementLib;

namespace UIProject.UserControls
{
    public partial class UC_Remboursement : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        int idSemaine = 0;
        int idRemboursement = 0;
        int panelWidth;

        bool isColapsed;
        int rowCount;
        public UC_Remboursement()
        {
            InitializeComponent();
            panelWidth = panelGrid.Height;
            isColapsed = false;

            
            
        }

        private void UC_Remboursement_Load(object sender, EventArgs e)
        {
            ChargemenCombos();
            Refresh(new Remboursement());
        }
        void Refresh(Remboursement remb)
        {
            
            dgRemboursement.DataSource = remb.AllRemboursements();
            //rowCount = dgRemboursement.Rows.Count;
            //rowCount = rowCount + 1;
            //dgRemboursement.Rows.Add(rowCount);
        }
        void ChargemenCombos()
        {
            dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_MEMBRE_NON_REMBOURSES");
            //dn.chargeCombo(fraisCombo, "Designation", "SELECT_DESIGNATION_FRAIS");
            //dn.chargeSemainesCombo(weeksCombo, "Nom_Complet", "SELECT_MEMBRE_NON_REMBOURSES");
            //fraisCombo.SelectedIndex = 0;
        }

        private void membreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           idSemaine = dn.retourInfoRembMembre(semaineLbl, matriculeLbl, mandataireLbl,membreCombo.Text,photo);
            //dn.retreivePhoto(matriculeLbl.Text, photo);
        }

        private void nouveauBtn_Click(object sender, EventArgs e)
        {
            ActionBtnNouveau();
        }
        void ActionBtnNouveau()
        {
            try
            {
                Remboursement remb = new Remboursement();

                idRemboursement = remb.Nouveau();

                nouveauBtn.Enabled = false;
                saveBtn.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suvant est survenue : " + ex.Message);
            }
        }
        void ActionBtnSave()
        {
            try
            {
                if (idRemboursement==0)
                {
                    MessageBox.Show("Vous devez cliquez d'abords sur la bouton nouvelle opération avant chaque enregistrement", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idSemaine==0)
                {
                    MessageBox.Show("Selectionner d'abord la semaine à remboursser dans la liste de choix", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    Remboursement remb = new Remboursement();

                    remb.Id = idRemboursement;
                    remb.RefSemaine = idSemaine;

                    remb.Enregistrer(remb);
                    Refresh(new Remboursement());
                    nouveauBtn.Enabled = true;
                    saveBtn.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suvant est survenue : " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ActionBtnSave();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {

                panelGrid.Height = panelGrid.Height + 10;

                panelAddCotisation.Visible = false;

                if (panelGrid.Height >= panelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();

                }



            }
            else
            {



                panelGrid.Height = panelGrid.Height - 10;


                if (panelGrid.Height <= 260)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                    panelAddCotisation.Visible = true;
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
