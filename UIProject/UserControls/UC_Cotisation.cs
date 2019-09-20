using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CotisationLib;
using UIProject.Classes;
using TontineUtilities;

namespace UIProject.UserControls
{
    public partial class UC_Cotisation : UserControl
    {
        int idCotisation = 0;
        int idSemaine = 0;
        int idInscription = 0;
        int idFrais = 0;
        DynamicClasses dn = new DynamicClasses();
        int panelWidth;
       
        bool isColapsed;

        public UC_Cotisation()
        {
            InitializeComponent();
            //timerTime.Start();
            panelWidth = panelGrid.Height;
            isColapsed = false;
        }
        void Ajouter()
        {
            try
            {
                Cotisation cot = new Cotisation();

                int rowCount;
                DateTime datenow;

                if (idCotisation == 0)
                {
                    MessageBox.Show("Avant chaque opération d'enregistrement veuillez cliqué d'abord sur le bouton Nouveau", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (membreCombo.Text == "" || dateCotTxt.Text == "" || montantTxt.Text == "" || fraisCombo.Text == "")
                {
                    MessageBox.Show("Completez tous les champs svp !!!", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else
                {
                    rowCount = dgManyCotisation.Rows.Count;
                    datenow = Convert.ToDateTime(dateCotTxt.Text);
                    if (lastLbl.Text == "Dernière contribution")
                    {
                        if (datenow.Date > InstantSemaine.GetInstance().DateFin.Date || datenow.Date < InstantSemaine.GetInstance().DateDebut.Date)
                        {
                            MessageBox.Show("Cette cotisation n'est concerne pas cette semaine, veillez cochez la case cotisation spéciale pour plus d'options ");
                        }
                        else
                        {
                            if (rowCount == 0)
                            {
                                idCotisation = cot.Nouveau();
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text);
                            }
                            else
                            {
                                idCotisation = idCotisation + 1;
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text);

                            }
                        }
                    }
                    else
                    {
                        if (datenow.Date <= Convert.ToDateTime(lastLbl.Text))
                        {
                            MessageBox.Show("Vérifier votre date svp, elle ne doit pas etre inférieure ou égale à la dernière contribution");
                        }
                        else if ((datenow.Date > InstantSemaine.GetInstance().DateFin.Date || datenow.Date < InstantSemaine.GetInstance().DateDebut.Date) && checkBox2.Checked==false)
                        {
                            MessageBox.Show("Cette cotisation n'est concerne pas cette semaine, veillez cochez la case cotisation spéciale pour plus d'options ");
                        }
                        else
                        {
                            if (rowCount == 0)
                            {
                                idCotisation = cot.Nouveau();
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text);
                            }
                            else
                            {
                                idCotisation = idCotisation + 1;
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text);

                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            ClicBtnNouveau();
            timer1.Start();
        }
        void ClicBtnNouveau()
        {
            try
            {
                Cotisation cot = new Cotisation();

                idCotisation = cot.Nouveau();

                nouveauBtn.Enabled = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DgManyCotisation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Cotisation_Load(object sender, EventArgs e)
        {
            ChargemenCombos();
            RefreshData(new Cotisation());
        }
        void RefreshData(Cotisation cot)
        {
            

            dgCotisation.DataSource = cot.AllCotisationSemaine(InstantSemaine.GetInstance().IdSemaine, InstantRound.GetInstance().Id);
        }
        void ChargemenCombos()
        {
            dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_NOMS_INSCRIPTIONS_FROM_ONE_ROUND");
            dn.chargeCombo(fraisCombo, "Designation", "SELECT_DESIGNATION_FRAIS");
            dn.chargeSemainesCombo(weeksCombo, "DebutFin", "SELECT_SEMAINE_DEBUT_FIN");
            fraisCombo.SelectedIndex = 0;
        }

        private void MembreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FraisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveDatas();
        }
        void SaveDatas()
        {
            if (checkBox1.Checked == true)
                SavePlusieur();
            else
                SaveOne();
        }
        private void SaveOne()
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(dateCotTxt.Text);
                Cotisation cot = new Cotisation();

                if (lastLbl.Text == "Dernière contribution")
                {
                    if (datenow.Date > InstantSemaine.GetInstance().DateFin.Date || datenow.Date < InstantSemaine.GetInstance().DateDebut.Date)
                    {
                        MessageBox.Show("Cette cotisation n'est concerne pas cette semaine, veillez cochez la case cotisation spéciale pour plus d'options ");
                    }
                    else
                    {
                        cot.Id = idCotisation;
                        cot.RefInscription = idInscription;
                        cot.RefSemaine = InstantSemaine.GetInstance().IdSemaine;
                        cot.DateConcernee = Convert.ToDateTime(dateCotTxt.Text);
                        cot.RefFrais = idFrais;
                        cot.Montant = montantTxt.Text;
                        cot.UserSession = UserSession.GetInstance().UserName;

                        cot.Enregistrer(cot);
                    }

                }
                else
                {
                    if (datenow.Date > Convert.ToDateTime(lastLbl.Text))
                    {
                        if (datenow.Date > InstantSemaine.GetInstance().DateFin.Date || datenow.Date < InstantSemaine.GetInstance().DateDebut.Date)
                        {
                            MessageBox.Show("Cette cotisation n'est concerne pas cette semaine, veillez cochez la case cotisation spéciale pour plus d'options ");
                        }
                        else
                        {
                            cot.Id = idCotisation;
                            cot.RefInscription = idInscription;
                            cot.RefSemaine = InstantSemaine.GetInstance().IdSemaine;
                            cot.DateConcernee = Convert.ToDateTime(dateCotTxt.Text);
                            cot.RefFrais = idFrais;
                            cot.Montant = montantTxt.Text;
                            cot.UserSession = UserSession.GetInstance().UserName;

                            cot.Enregistrer(cot);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vérifier votre date svp, elle ne doit pas etre inférieure ou égale à la dernière contribution");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void SavePlusieur()
        {
            try
            {

                Cotisation cot = new Cotisation();

                for (int i = 0; i < (dgManyCotisation.Rows.Count); i++)
                {

                    if (idSemaine != 0)
                    {
                        cot.Id = Convert.ToInt32(dgManyCotisation[0, i].Value.ToString());
                        cot.RefInscription = idInscription;
                        cot.RefSemaine = Convert.ToInt32(dgManyCotisation[1, i].Value.ToString());
                        cot.DateConcernee = Convert.ToDateTime(dgManyCotisation[2, i].Value.ToString());
                        cot.RefFrais = idFrais;
                        cot.Montant = dgManyCotisation[3, i].Value.ToString();
                        cot.UserSession = UserSession.GetInstance().UserName;

                        cot.Enregistrer(cot);
                    }
                    else
                    {
                        cot.Id = Convert.ToInt32(dgManyCotisation[0, i].Value.ToString());
                        cot.RefInscription = idInscription;
                        cot.RefSemaine = InstantSemaine.GetInstance().IdSemaine;
                        cot.DateConcernee = Convert.ToDateTime(dgManyCotisation[2, i].Value.ToString());
                        cot.RefFrais = idFrais;
                        cot.Montant = dgManyCotisation[3, i].Value.ToString();
                        cot.UserSession = UserSession.GetInstance().UserName;

                        cot.Enregistrer(cot);
                    }


                }


                dgManyCotisation.Rows.Clear();
                nouveauBtn.Enabled = true;
                saveBtn.Enabled = false;
                //idEnteteSortie = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void weeksCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void membreCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idInscription = dn.retourIdM(membreCombo.Text);
            situationLbl.Text = dn.retourLastCotisationMembre(lastLbl, fraisLbl, idInscription);
        }

        private void fraisCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idFrais = dn.retourId("Id", "Type_Frais", "Designation", fraisCombo.Text);
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                //checkBox1.Checked = false;
                weeksCombo.Visible = true;
                weekLbl.Visible = true;
            }

            else if (checkBox2.Checked == false)
            {
                //checkBox1.Checked = true;
                weeksCombo.Visible = false;
                weekLbl.Visible = false;
            }
        }

        private void weeksCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idSemaine = dn.retourIdSemaine(weeksCombo.Text);
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (membreCombo.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    //checkBox1.Checked = false;
                    membreCombo.Enabled = false;
                    addBtn.Visible = true;
                }

                else if (checkBox1.Checked == false)
                {
                    //checkBox1.Checked = true;
                    membreCombo.Enabled = true;
                    addBtn.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Veuillez selectionner un membre avant de cliquer ici");
                checkBox1.Checked = false;
            }
        }
    }
}
