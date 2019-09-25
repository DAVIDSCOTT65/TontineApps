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
        int num = 0;
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
                        num = num + 1;

                        dgTirage.Rows.Add(num,idSemaine.ToString(), membreCombo.Text, idInscription);

                        membreCombo.Items.Remove(membreCombo.Text);
                        membreCombo.Text = "";
                    }
                    else
                    {
                        idSemaine = idSemaine + 1;
                        num = num + 1;

                        dgTirage.Rows.Add(num,idSemaine.ToString(), membreCombo.Text, idInscription);

                        membreCombo.Items.Remove(membreCombo.Text);
                        membreCombo.Text = "";

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

        private void button4_Click(object sender, EventArgs e)
        {
            int rowCount ;
            rowCount = dgTirage.Rows.Count;
            if (rowCount==0)
            {
                addBtn.Enabled = true;
            }
            else
            {
                for (int i = 0; i < rowCount; i++)
                {

                    if (membreCombo.Text != dgTirage.Rows[i].Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Ce membre n'a pas encore effectuer de tirage", "Attention");

                        addBtn.Enabled = true;
                    }
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDatas();
        }
        void SaveDatas()
        {
            try
            {
                Semaine sem = new Semaine();
                for (int i = 0; i < (dgTirage.Rows.Count); i++)
                {

                    sem.Id = Convert.ToInt32(dgTirage[1, i].Value.ToString());
                    sem.RefInscrit = Convert.ToInt32(dgTirage[3, i].Value.ToString());
                    

                    sem.Enregistrer(sem);

                }
                MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgTirage.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
