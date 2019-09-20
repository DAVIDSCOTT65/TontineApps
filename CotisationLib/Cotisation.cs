using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotisationLib
{
    public class Cotisation
    {
        public int Id { get; set; }
        public int RefInscription { get; set; }
        public int RefSemaine { get; set; }
        public DateTime DateCotisation { get; set; }
        public DateTime DateConcernee { get; set; }
        public string Montant { get; set; }
        public double Mont { get; set; }
        public int RefFrais { get; set; }
        public int RefRound { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Designation { get; set; }
        public string UserSession { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Cotisation";
                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["LastId"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(rd["LastId"].ToString()) + 1;
                }
                rd.Dispose();
            }
            return Id;
        }
        public void Enregistrer(Cotisation cot)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_COTISATION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_inscription", 4, DbType.Int32, RefInscription));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_semaine", 4, DbType.Int32, RefSemaine));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@date_concerne", 20, DbType.Date, DateConcernee));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_frais", 4, DbType.Int32, RefFrais));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@montant", 4, DbType.Decimal, Convert.ToDecimal(Montant)));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@usersession", 30, DbType.String, UserSession));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE_COTISATION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public List<Cotisation> AllCotisationDay(int idRound)
        {
            List<Cotisation> lst = new List<Cotisation>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_COTISATIONS_FROM_ROUND_TODAY";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "IdRound", 4, DbType.Int32, idRound));
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDetailCotisation(rd));
                }
                rd.Dispose();
            }
            return lst;
        }
        public List<Cotisation> AllCotisationSemaine(int idSemaine, int idRound)
        {
            List<Cotisation> lst = new List<Cotisation>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_COTISATIONS_FROM_ROUND_WEEK";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@IdRound", 5, DbType.Int32, idRound));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@IdSemaine", 5, DbType.Int32, idSemaine));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDetailCotisation(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Cotisation GetDetailCotisation(IDataReader dr)
        {
            Cotisation cot = new Cotisation();
            cot.Id = Convert.ToInt32(dr["Id"].ToString());
            cot.DateCotisation = Convert.ToDateTime(dr["Date_Cotisation"].ToString());
            cot.DateConcernee = Convert.ToDateTime(dr["Date_Concernee"].ToString());
            cot.Montant = dr["Montant"].ToString();
            cot.Mont = Convert.ToDouble(dr["Mont"].ToString());
            cot.RefInscription = Convert.ToInt32(dr["IdInscription"].ToString());
            cot.RefRound = Convert.ToInt32(dr["IdRound"].ToString());
            cot.Matricule = dr["Matricule"].ToString();
            cot.Nom = dr["Nom"].ToString();
            cot.Postnom = dr["Postnom"].ToString();
            cot.Prenom = dr["Prenom"].ToString();
            cot.Sexe = dr["Sexe"].ToString();
            cot.RefSemaine = Convert.ToInt32(dr["IdSemaine"].ToString());
            cot.RefFrais = Convert.ToInt32(dr["IdFrais"].ToString());
            cot.Designation = dr["Designation"].ToString();

            return cot;
        }
    }
}
