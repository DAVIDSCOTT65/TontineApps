using RemboursementLib;
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
using UIProject.Classes;

namespace UIProject.UserControls
{
    public partial class Form1 : Form
    {
        DynamicClasses dn = new DynamicClasses();
        int idInscription=0;
        int idSemaine = 0;
        public Form1()
        {
            InitializeComponent();
            dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_MEMBRE_NON_TIRER");
        }
        void Ajouter()
        {
            try
            {
                Semaine sem = new Semaine();

                

                int rowCount;

                if (idInscription==0)
                {
                    MessageBox.Show("Veuillez selectionner l'identité du membre d'abord");
                }
                else
                {
                    rowCount = dgTirage.Rows.Count;

                    
                    
                    if (rowCount == 0)
                    {
                        
                        idSemaine = sem.Nouveau();

                        //sem.Id = idSemaine;
                        //sem.RefInscrit = idInscription;
                        //sem.IdRound = InstantRound.GetInstance().Id;
                        //sem.Enregistrer(sem);

                        dgTirage.Rows.Add(idSemaine.ToString(), membreCombo.Text, idInscription);
                        membreCombo.Items.Clear();
                        dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_MEMBRE_NON_TIRER");
                        membreCombo.Text = "";
                    }
                    else
                    {
                        for (int i = 0; i < dgTirage.Rows.Count; i++)
                        {
                            if (membreCombo.Text == dgTirage.Rows[i].Cells[1].Value.ToString())
                            {
                                MessageBox.Show("Ce membre existe déjà","Terminer");
                                
                            }
                            else
                            {
                                idSemaine = idSemaine + 1;

                                //sem.Id = idSemaine;
                                //sem.RefInscrit = idInscription;
                                //sem.IdRound = InstantRound.GetInstance().Id;
                                //sem.Enregistrer(sem);

                                dgTirage.Rows.Add(idSemaine.ToString(), membreCombo.Text, idInscription);
                                membreCombo.Items.Clear();
                                dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_MEMBRE_NON_TIRER");
                                membreCombo.Text = "";
                                
                            }
                        }

                        

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void membreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idInscription = dn.retourIdM(membreCombo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter();
        }
    }
}
