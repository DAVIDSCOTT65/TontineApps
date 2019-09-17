using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MembreLib;
using InscriptionLib;
using TontineUtilities;
using UIProject.Classes;
using UIProject.Forms;

namespace UIProject.UserControls
{
    public partial class UC_Member : UserControl
    {
        int idMembre=0;
        int idInscription = 0;
        int idPhone = 0;
        int idMandataire = 0;
        clsImabar codage = new clsImabar();
        DynamicClasses dn = new DynamicClasses();



        public UC_Member()
        {
            InitializeComponent();
        }

        private void UC_Member_Load(object sender, EventArgs e)
        {
            RefreshDatas(new Inscription());
        }
        void RefreshDatas(IInscription insc)
        {
            dgInscit.DataSource = insc.AllInscriptionsRound(InstantRound.GetInstance().Id);
            sexeTxt.DataSource = Enum.GetNames(typeof(Sexe));
            dn.chargeCombo(membreCombo, "Nom_Complet", "SELECT_NOM_COMPLET_MEMBRE");
        }
        void ActionNouveau()
        {
            Mandataire mandataire = new Mandataire();
           idMandataire = mandataire.Nouveau();
            IMembre membre = new Membre();
            idMembre = membre.Nouveau();
            Telephone phone = new Telephone();
            idPhone = phone.Nouveau();
            IInscription insc = new Inscription();
            idInscription = insc.Nouveau();

            nouveauBtn.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ActionNouveau();
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue " + ex.Message);
            }
        }
        void SaveMandataire()
        {
            Mandataire m = new Mandataire();

            m.Id = idMandataire;
            m.Noms = nomsTxt.Text;
            m.Contat = contactTxt.Text;
            m.Profession = profTxt.Text;
            m.DateNaiss = DateTime.Parse(naissTxt.Text);

            m.Enregistrer(m);
        }
        void SaveMembre()
        {
            Membre membre = new Membre();

            GenererQrCode();
            InstantRound.GetInstance().IdMembre = idMembre;
            membre.Id = idMembre;
            membre.Matricule = "00000000";
            membre.Nom = nomTxt.Text;
            membre.Postnom = pnomTxt.Text;
            membre.Prenom = prenomTxt.Text;
            membre.Sex = sexeTxt.Text.Equals(Sexe.Masculin.ToString()) ? Sexe.Masculin : Sexe.Féminin;
            membre.DateNaiss = DateTime.Parse(dateNaissTxt.Text);
            membre.LieuNaiss = lieuTxt.Text;
            membre.Profession = professionTxt.Text;
            membre.QrCode = qrCode.Image;
            membre.Photo = photo.Image;
            membre.RefMandataire = idMandataire;

            membre.Enregistrer(membre);
        }
        void SavePhone()
        {
            Telephone telephone = new Telephone();

            telephone.Id = idPhone;
            telephone.Initial = initial.Text;
            telephone.Numero = contactTxt.Text;
            telephone.RefMembre = idMembre;

            telephone.Enregistrer(telephone);
        }
        void SaveInscription()
        {
            IInscription I = new Inscription();

            I.Id = Convert.ToInt32(idInscription);
            I.RefMembre = idMembre;
            I.RefRound = InstantRound.GetInstance().Id;
            I.UserSession = UserSession.GetInstance().UserName.ToString();

            I.Enregistrer(I);

        }
        void SaveDatas()
        {
            try
            {
                if(idInscription==0 || idMembre==0 || idPhone==0 || idMandataire==0 || nomTxt.Text=="" || pnomTxt.Text==""|| prenomTxt.Text=="" || dateNaissTxt.Text == "" || lieuTxt.Text == "" || sexeTxt.Text == "" || professionTxt.Text=="" || initial.Text=="" || phoneTxt.Text=="" || nomsTxt.Text=="" || contactTxt.Text==""|| profTxt.Text=="" || naissTxt.Text=="")
                {
                    MessageBox.Show("Veuillez remplir tous les champs avant de continuer svp !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (membreCombo.Visible == true)
                    {
                        idMembre = dn.retourId("IdMembre", "Affichage_Details_Inscriptions", "Nom_Complet", membreCombo.Text);
                        SaveInscription();
                    }
                    else
                    {
                        SaveMandataire();
                        SaveMembre();
                        SavePhone();
                        SaveInscription();
                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveDatas();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
        }
        void GenererQrCode()
        {
            try
            {
                string encode = idMembre.ToString();
                codage.QRCode(qrCode, encode);
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors de la génération du code Qr : " + ex.Message);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                membreCombo.Visible = true;
                EtatChamps(false);

            }
            else
            {
                membreCombo.Visible = false;
                EtatChamps(true);
            }
        }
        void EtatChamps(bool etat)
        {
            matriculeTxt.Enabled = etat;
            nomTxt.Enabled = etat;
            pnomTxt.Enabled = etat;
            prenomTxt.Enabled = etat;
            sexeTxt.Enabled = etat;
            dateNaissTxt.Enabled = etat;
            lieuTxt.Enabled = etat;
            professionTxt.Enabled = etat;
            initial.Enabled = etat;
            phoneTxt.Enabled = etat;
            nomsTxt.Enabled = etat;
            contactTxt.Enabled = etat;
            profTxt.Enabled = etat;
            naissTxt.Enabled = etat;
        }

        private void MembreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //idMembre = dn.retourId("IdMembre", "Affichage_Details_Inscriptions", "Nom_Complet", membreCombo.Text);
          idMembre=dn.retourInfoMembre(matriculeTxt, nomTxt, pnomTxt, prenomTxt, sexeTxt, dateNaissTxt, lieuTxt, professionTxt, nomsTxt, membreCombo.Text);
          //dn.retreivePhoto(idMembre.ToString(), photo);
            loadPhoto(idMembre.ToString(), photo);
        }
        void loadPhoto(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id,pic);
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();

            try
            {
                if (openDlg.FileName != null)
                {
                    // try to open the file
                    this.photo.Image = Bitmap.FromFile(openDlg.FileName);
                    //this.tbFileName.Text = openDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement de la photo : "+ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            if (InstantRound.GetInstance().IdMembre==0)
            {
                MessageBox.Show("Veuillez selectionner un membre dans le Tableau");
            }
            else
            {
                MiniFormAdresse m = new MiniFormAdresse();
                m.ShowDialog();
            }
            
        }

        private void DgInscit_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgInscit.CurrentRow.Index;


                InstantRound.GetInstance().IdMembre = Convert.ToInt32(dgInscit["idM", i].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
