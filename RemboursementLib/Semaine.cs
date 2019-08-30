using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemboursementLib
{
    public class Semaine
    {
        public int Id { get; set; }
        public int RefInscrit { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int RefDetail { get; set; }
        public Decimal Montant { get; set; }
        public string Devise { get; set; }
        public int IdRound { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Semaine";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["LastId"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(dr["LastId"].ToString()) + 1;
                }
                dr.Dispose();
            }
            return Id;
        }
        public void Enregistrer(Semaine sem)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_SEMAINE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@numero", 4, DbType.Int32, RefInscrit));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@refdetail", 4, DbType.Int32, RefDetail));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@debut", 20, DbType.Date, DateDebut));

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
                cmd.CommandText = "DELETE_SEMAINE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Semaine> AllSemaines(int idRound)
        {
            List<Semaine> semaine = new List<Semaine>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_SEMAINES_FROM_ROUND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, idRound));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    semaine.Add(GetSemaineDetails(rd));
                }
                rd.Dispose();
            }
            return semaine;
        }
        private Semaine GetSemaineDetails(IDataReader rd)
        {
            Semaine s = new Semaine();

            s.Id = Convert.ToInt32(rd["Id"].ToString());
            s.DateDebut = Convert.ToDateTime(rd["Date_Debut"].ToString());
            s.DateFin = Convert.ToDateTime(rd["Date_Fin"].ToString());
            s.RefDetail = Convert.ToInt32(rd["IdDetail"].ToString());
            s.Montant = Convert.ToDecimal(rd["Montant"].ToString());
            s.Devise = rd["Devise"].ToString();
            s.RefInscrit= Convert.ToInt32(rd["IdInscrit"].ToString());
            s.IdRound= Convert.ToInt32(rd["IdRound"].ToString());
            s.Matricule = rd["Matricule"].ToString();
            s.Nom = rd["Nom"].ToString();
            s.Postnom = rd["Postnom"].ToString();
            s.Prenom = rd["Prenom"].ToString();
            s.Sexe = rd["Sexe"].ToString();

            return s;

        }
    }
}
