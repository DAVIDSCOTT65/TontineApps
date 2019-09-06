using MembreLib;
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

namespace UIProject.Forms
{
    public partial class MiniFormAdresse : Form
    {
        int idAdresse = 0;
        int idDomicile = 0;
        int idPhone = 0;
        bool gridClic;
        public MiniFormAdresse()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveDatas();
        }
        void RefreshDatas(Domicile insc)
        {
            dgInscit.DataSource = insc.AllAdresses();
            
        }
        void SaveAdresse()
        {
            Adresse ad = new Adresse();

            ad.Id = idAdresse;
            ad.Pays = paysTxt.Text;
            ad.Ville = villeTxt.Text;
            ad.Commune = comTxt.Text;
            ad.Quartier = quartierTxt.Text;

            ad.Enregistrer(ad);
        }
        void SavePhone()
        {
            Telephone telephone = new Telephone();

            telephone.Id = idPhone;
            telephone.Initial = initial.Text;
            telephone.Numero = contactTxt.Text;
            telephone.RefMembre = InstantRound.GetInstance().IdMembre;

            telephone.Enregistrer(telephone);
        }
        void SaveDomicile()
        {
            Domicile dom = new Domicile();

            dom.Id = idDomicile;
            dom.Avenue = avenueTxt.Text;
            dom.Numero = numTxt.Text;
            dom.RefAdresse = idAdresse;
            dom.RefMembre= InstantRound.GetInstance().IdMembre;

            dom.Enregistrer(dom);
        }
        void SaveDatas()
        {
            if (idAdresse==0 || idDomicile==0 || idPhone==0)
            {
                MessageBox.Show("Veuillez cliquer sur le bouton nouveau avant toute opérations !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (paysTxt.Text=="" || villeTxt.Text=="" || comTxt.Text=="" || quartierTxt.Text =="" || avenueTxt.Text == "" || numTxt.Text=="" || initial.Text =="" || contactTxt.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de continuer svp !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridClic==true)
                {
                    SavePhone();
                    SaveDomicile();
                }
                else if(gridClic==false)
                {
                    SaveAdresse();
                    SavePhone();
                    SaveDomicile();
                }
                
            }
           
        }
        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            LastId();
        }
        private void LastId()
        {
            gridClic = false;
            try
            {
                Adresse ad = new Adresse();
                idAdresse = ad.Nouveau();

                Domicile dom = new Domicile();
                idDomicile = dom.Nouveau();

                Telephone tel = new Telephone();
                idPhone = tel.Nouveau();
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : "+ex.Message);
            }
        }

        private void MiniFormAdresse_Load(object sender, EventArgs e)
        {
            RefreshDatas(new Domicile());
        }
        void clic_grid()
        {
            gridClic = true;
            idAdresse = 0;
            try
            {
                int i;
                i = dgInscit.CurrentRow.Index;


                idAdresse = Convert.ToInt32(dgInscit["id", i].Value.ToString());
                paysTxt.Text = dgInscit["pays", i].Value.ToString();
                villeTxt.Text = dgInscit["ville", i].Value.ToString();
                comTxt.Text = dgInscit["commune", i].Value.ToString();
                quartierTxt.Text = dgInscit["quart", i].Value.ToString();
                avenueTxt.Text = dgInscit["avenue", i].Value.ToString();
                

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void DgInscit_SelectionChanged(object sender, EventArgs e)
        {
            clic_grid();
        }

        private void DgInscit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clic_grid();
        }
    }
}
