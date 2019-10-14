using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;
using ManageSingleConnection;
using ParametreConnexionLib;
using CotisationLib;
using System.Data.SqlClient;
using UIProject.Classes;
using System.IO;

namespace UIProject.UserControls
{
    public partial class UC_Home : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        int panelWidth;
        bool isColapsed;
        public UC_Home()
        {
            InitializeComponent();
            isColapsed = false;
            panelWidth = panelGrid.Height;
        }
        private void LoadSemaine()
        {
            //InstantSemaine semaine = new InstantSemaine();

            ////semaine.OneSemaine(InstantRound.GetInstance().Id);

            //lblNom.Text = semaine.NomComplet;
            //lblDebut.Text = semaine.DateDebut.ToString();
            //lblFin.Text = semaine.DateFin.ToString();


        }
        private void OneSemaine(int id)
        {

             
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_DETAILS_SEMAINE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DateTime dateco, datefin = new DateTime();
                    dateco = Convert.ToDateTime(dr["Date_Debut"].ToString());
                    datefin = Convert.ToDateTime(dr["Date_Fin"].ToString());

                    InstantSemaine.GetInstance().IdSemaine = Convert.ToInt32(dr["Id"].ToString());
                    InstantSemaine.GetInstance().DateDebut= Convert.ToDateTime(dr["Date_Debut"].ToString());
                    InstantSemaine.GetInstance().DateFin = Convert.ToDateTime(dr["Date_Fin"].ToString());
                    InstantSemaine.GetInstance().NomComplet= dr["Nom_Complet"].ToString();

                    lblDebut.Text = string.Format("{0}", dateco.ToString("dd/MM/yyyy"));
                    lblFin.Text = string.Format("{0}", datefin.ToString("dd/MM/yyyy"));
                    lblNom.Text = dr["Nom_Complet"].ToString();
                }

                dr.Dispose();
            }
            OneInfoSemaine();
            dn.retreivePhoto2("Photo", "Affichage_Details_Semaine", "Id", InstantSemaine.GetInstance().IdSemaine.ToString(), pictureBox3);

            //return semaine;
        }
        void ChartCotisation()
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Date_Concernee, SUM(Mont) as Montant FROM Affichage_Details_Cotisation WHERE IdSemaine='" + InstantSemaine.GetInstance().IdSemaine + "' GROUP BY Date_Concernee", (SqlConnection) ImplementeConnexion.Instance.Conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chartWeek.DataSource = dt;




                chartWeek.ChartAreas["ChartAreas1"].AxisX.Title = "Date";
                chartWeek.ChartAreas["ChartAreas1"].AxisX.Title = "Montant";

                chartWeek.Series["Cotisation"].XValueMember = "Date_Concernee";
                chartWeek.Series["Cotisation"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartWeek.Series["Cotisation"].YValueMembers = "Montant";
                chartWeek.Series["Cotisation"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Une erreur est survenue : "+ex.Message);
            }
        }
        private void OneInfoSemaine()
        {


            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_CAISSE_RESTE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, InstantSemaine.GetInstance().IdSemaine));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@idRound", 4, DbType.Int32, InstantRound.GetInstance().Id));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblCaisse.Text = dr["En_Caisse"].ToString();
                    lblReste.Text = dr["Dette"].ToString();
                    
                }

                dr.Dispose();
            }

            //return semaine;
        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
            
            OneSemaine(InstantRound.GetInstance().Id);
            ChartCotisation();
            RefreshData(new Cotisation());
            lblMax.Text = dgCotisation.Rows.Count.ToString();
        }
        void RefreshData(Cotisation cot)
        {
            dgCotisation.DataSource = cot.AllDettes();
        }
        private void LoadChart()
        {
            chartWeek.Series["Week"].Points.AddXY("Day1", 8000);
            chartWeek.Series["Week"].Points.AddXY("Day2", 5000);
            chartWeek.Series["Week"].Points.AddXY("Day3", 3000);
            chartWeek.Series["Week"].Points.AddXY("Day4", 1000);
            chartWeek.Series["Week"].Points.AddXY("Day5", 1000);
            chartWeek.Series["Week"].Points.AddXY("Day6", 3000);
            chartWeek.Series["Week"].Points.AddXY("Day7", 7000);
            chartWeek.Series["Week"].Points.AddXY("Day8", 4000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Home fr = new UC_Home();
            fr.Refresh();
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isColapsed)
            {

                panelGrid.Height = panelGrid.Height - 10;

                //panelAddCotisation.Visible = false;

                if (panelGrid.Height <= panelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();

                }



            }
            else
            {



                panelGrid.Height = panelGrid.Height + 10;


                if (panelGrid.Height >= 417)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                    //panelAddCotisation.Visible = true;
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"C:\cheminBdTontine\Ico\Up.png",FileMode.Open))
            {
                if (panelGrid.Height >= 417)
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

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchDette(new Cotisation());
        }
        void SearchDette(Cotisation cot)
        {
            dgCotisation.DataSource = cot.ResearchDette(serchTxt.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SearchDette(new Cotisation());
        }
    }
}
