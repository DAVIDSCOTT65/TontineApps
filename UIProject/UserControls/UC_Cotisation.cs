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
using System.IO;

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
        DateTime dateCotise = new DateTime();
        int inc = 0;
        
       
        bool isColapsed;

        public UC_Cotisation()
        {
            InitializeComponent();
            dateCotise = DateTime.Now;
            //timerTime.Start();
            panelWidth = panelGrid.Height;
            isColapsed = false;
            lastLbl.Text = InstantSemaine.GetInstance().DateDebut.ToString("dd/MM/yyyy");
            saveBtn.Enabled = false;
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

                    dateCotise = Convert.ToDateTime(dateCotTxt.Text);
                    

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
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text, chkSocial.Checked == true ? 1 : 0);
                                dateCotTxt.Text = dateCotise.AddDays(1).ToString();
                            }
                            else
                            {
                                idCotisation = idCotisation + 1;
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text, chkSocial.Checked == true ? 1 : 0);
                                dateCotTxt.Text = dateCotise.AddDays(1).ToString();

                            }
                        }
                    }
                    else
                    {
                        if (datenow.Date <= Convert.ToDateTime(lastLbl.Text) && situationLbl.Text != "Prémière Cotisation")
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
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text, chkSocial.Checked == true ? 1 : 0);
                                dateCotTxt.Text = dateCotise.AddDays(1).ToString();
                            }
                            else
                            {
                                idCotisation = idCotisation + 1;
                                dgManyCotisation.Rows.Add(idCotisation.ToString(), idSemaine, dateCotTxt.Text, montantTxt.Text, chkSocial.Checked==true ? 1 : 0);
                                dateCotTxt.Text = dateCotise.AddDays(1).ToString();

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
            
        }
        void ClicBtnNouveau()
        {
            try
            {
                Cotisation cot = new Cotisation();

                idCotisation = cot.Nouveau();

                nouveauBtn.Enabled = false;
                saveBtn.Enabled = true;


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
            chkSocial.Checked = true;
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
        void Initialise()
        {
            checkBox1.Checked = false;
            idCotisation = 0;
            membreCombo.Text = "";
            membreCombo.Enabled = true;
            dateCotTxt.Text = "";
            montantTxt.Text = "0";
            fraisCombo.Text = "";
            
        }
        void SaveDatas()
        {
            if (checkBox1.Checked == true)
                SavePlusieur();
            
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

                        Initialise();
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

                            Initialise();
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
                        cot.Cas = Convert.ToInt32(dgManyCotisation[4, i].Value.ToString());
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
                        cot.Cas = Convert.ToInt32(dgManyCotisation[4, i].Value.ToString());
                        cot.UserSession = UserSession.GetInstance().UserName;

                        cot.Enregistrer(cot);

                        //MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Initialise();
                    }


                }
                

                MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dgManyCotisation.Rows.Clear();
                nouveauBtn.Enabled = true;
                saveBtn.Enabled = false;
                Initialise();
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

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void membreCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectCombo();
        }
        void SelectCombo()
        {
            idInscription = dn.retourIdM(membreCombo.Text);
            situationLbl.Text = dn.retourLastCotisationMembre(lastLbl, fraisLbl, idInscription);

            if (situationLbl.Text == "Prémière Cotisation")
            {
                lastLbl.Text = InstantSemaine.GetInstance().DateDebut.ToString("dd/MM/yyyy");
                dateCotise = Convert.ToDateTime(lastLbl.Text);
                dateCotTxt.Text = lastLbl.Text;
                membreCombo.Enabled = false;
                addBtn.Visible = true;
                checkBox1.Checked = true;
                situationLbl.Text = "Prémière Cotisation";

                //situationLbl.Text = "Deuxième Cotisation";
                inc = 1;
            }
            else
            {
                if (dateCotise.ToString("dd/MM/yyyy") == lastLbl.Text && situationLbl.Text == "Prémière Cotisation")
                {
                    if (inc == 0)
                    {

                        dateCotise = Convert.ToDateTime(lastLbl.Text);
                        dateCotTxt.Text = lastLbl.Text;
                        membreCombo.Enabled = false;
                        addBtn.Visible = true;
                        checkBox1.Checked = true;
                        situationLbl.Text = "Prémière Cotisation";
                        inc = 1;
                    }
                    else
                    {
                        //idInscription = dn.retourIdM(membreCombo.Text);
                        //situationLbl.Text = dn.retourLastCotisationMembre(lastLbl, fraisLbl, idInscription);
                        dateCotise = Convert.ToDateTime(lastLbl.Text);
                        dateCotTxt.Text = dateCotise.AddDays(1).ToString();
                        membreCombo.Enabled = false;
                        addBtn.Visible = true;
                        situationLbl.Text = "Deuxième Cotisation";
                        checkBox1.Checked = true;
                    }

                }
                else
                {
                    //idInscription = dn.retourIdM(membreCombo.Text);
                    //situationLbl.Text = dn.retourLastCotisationMembre(lastLbl, fraisLbl, idInscription);
                    dateCotise = Convert.ToDateTime(lastLbl.Text);
                    dateCotTxt.Text = dateCotise.AddDays(1).ToString();
                    membreCombo.Enabled = false;
                    addBtn.Visible = true;
                    checkBox1.Checked = true;
                }
            }
           
            
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

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new Cotisation());
        }
        void Search(Cotisation cot)
        {
            dgCotisation.DataSource = cot.Research(serchTxt.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream(@"C:\cheminBdTontine\Ico\Up.png", FileMode.Open))
            {
                if (panelGrid.Height >= 260)
                {
                    FileStream f = new FileStream(@"C:\cheminBdTontine\Ico\Down.png", FileMode.Open);
                    button7.Image = Image.FromStream(f);
                    f.Close();
                }
                else
                {
                    button7.Image = Image.FromStream(fs);
                }

            }
            timer1.Start();
        }
    }
}
