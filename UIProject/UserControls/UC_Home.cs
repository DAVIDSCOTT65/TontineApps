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

namespace UIProject.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
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
                    lblDebut.Text = string.Format("{0}", dateco.ToString("dd/MM/yyyy"));
                    lblFin.Text = string.Format("{0}", datefin.ToString("dd/MM/yyyy"));
                    lblNom.Text = dr["Nom_Complet"].ToString();
                }

                dr.Dispose();
            }

            //return semaine;
        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
            OneSemaine(InstantRound.GetInstance().Id);
            LoadChart();
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
    }
}
