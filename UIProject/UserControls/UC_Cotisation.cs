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

namespace UIProject.UserControls
{
    public partial class UC_Cotisation : UserControl
    {
        int idCotisation = 0;
        int idSemaine = 0;
        int idInscription = 0;
        int idFrais = 0;
        DynamicClasses dn = new DynamicClasses();

        public UC_Cotisation()
        {
            InitializeComponent();
        }
        void Ajouter()
        {
            try
            {
                Cotisation cot = new Cotisation();

                int rowCount;

                if (idCotisation == 0)
                {
                    MessageBox.Show("Avant chaque opération d'enregistrement veuillez cliqué d'abord sur le bouton Nouveau", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (membreCombo.Text == "" || dateCotTxt.Text == "" || montantTxt.Text == "" || fraisCombo.Text=="")
                {
                    MessageBox.Show("Completez tous les champs svp !!!", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                //else if (stock <= 0 || stock < int.Parse(textBox3.Text))
                //{
                //    MessageBox.Show("Vérifiez votre stock avant d'effectuer cette opération!!!", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //}
                else
                {
                    rowCount = dgManyCotisation.Rows.Count;

                    if (rowCount == 0)
                    {
                        idCotisation = cot.Nouveau();
                        dgManyCotisation.Rows.Add(idCotisation.ToString(), dateCotTxt.Text, montantTxt.Text);
                        //label8.Text = dataGridView2.Rows.Count.ToString() + " médicaments";
                        //idDetailSortie = 0;
                    }
                    else
                    {
                        idCotisation = idCotisation + 1;
                        
                        //    {
                        dgManyCotisation.Rows.Add(idCotisation.ToString(), dateCotTxt.Text, montantTxt.Text);
                        //label8.Text = dataGridView2.Rows.Count.ToString() + " médicaments";
                        //idDetailSortie = 0;
                        //}
                        //}
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
            if (membreCombo.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    //checkBox1.Checked = false;
                    membreCombo.Enabled = false;
                    addBtn.Visible = true;
                }
                    
                else if(checkBox1.Checked == false)
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


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void DgManyCotisation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Cotisation_Load(object sender, EventArgs e)
        {
            ChargemenCombos();
        }
        void ChargemenCombos()
        {
            dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_NOMS_INSCRIPTIONS_FROM_ONE_ROUND");
            dn.chargeCombo(fraisCombo, "Designation", "SELECT_DESIGNATION_FRAIS");
            fraisCombo.SelectedIndex = 0;
        }

        private void MembreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idInscription = dn.retourId("Id", "Affichage_Details_Inscriptions", "Nom_Complet", membreCombo.Text);
        }

        private void FraisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFrais = dn.retourId("Id", "Type_Frais", "Designation", fraisCombo.Text);
        }
    }
}
