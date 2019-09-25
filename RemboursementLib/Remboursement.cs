using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;

namespace RemboursementLib
{
   public  class Remboursement
    {
        int i;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefInscription { get; set; }
        public int RefSemaine { get; set; }
        public int IdRound { get; set; }
        public string Matricule { get; set; }
        public string Noms { get; set; }
        public string Montant { get; set; }
        public string Sexe { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }
        public DateTime Date_Remboursement { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Remboursement";
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
        public void Enregistrer(Remboursement remb)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_REMBOURSEMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_semaine", 4, DbType.Int32, RefSemaine));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@usersession", 50, DbType.String, UserSession.GetInstance().UserName));

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
                cmd.CommandText = "DELETE_REMBOURSEMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Remboursement> AllRemboursements()
        {
            List<Remboursement> r = new List<Remboursement>();
            //Num = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_REMBOURSEMENTS_FROM_ROUND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, InstantRound.GetInstance().Id));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    
                    r.Add(GetDetailsRemboursement(rd));
                }
                rd.Dispose();
            }
            return r;
        }
        private Remboursement GetDetailsRemboursement(IDataReader rd)
        {
            Remboursement r = new Remboursement();

            i = i + 1;

            

            r.Num = i;
            r.Id = Convert.ToInt32(rd["Id"].ToString());
            r.RefInscription = Convert.ToInt32(rd["IdInscription"].ToString());
            r.IdRound = Convert.ToInt32(rd["IdRound"].ToString());
            r.Matricule = rd["Matricule"].ToString();
            r.Noms = rd["Nom_Complet"].ToString();
            r.Montant = rd["Montant"].ToString();
            r.Sexe = rd["Sexe"].ToString();
            r.RefSemaine = Convert.ToInt32(rd["IdSemaine"].ToString());
            r.Date_Debut = Convert.ToDateTime(rd["Date_Debut"].ToString());
            r.Date_Fin = Convert.ToDateTime(rd["Date_Fin"].ToString());
            r.Date_Remboursement = Convert.ToDateTime(rd["Date_Remboursement"].ToString());
            return r;
            
        }
    }
}
