using ManageSingleConnection;
using MembreLib;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscriptionLib
{
    public class Inscription : IInscription
    {
        int i;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefRound { get; set; }

        public int RefMembre { get; set; }

        public string UserSession { get; set; }

        public DateTime DateInscrit { get; set; }

        public string Matricule { get; set; }

        public string Nom { get; set; }

        public string Postnom { get; set; }

        public Sexe Sexe { get; set; }

        public string Designation { get; set; }

        public string Prenom { get; set; }
        public string NomComplet { get; set; }
        public List<IInscription> AllInscriptionsRound(int idround)
        {
            List<IInscription> lst = new List<IInscription>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_INSCRIPTIONS_FROM_ONE_ROUND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, idround));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetAllDetailsInscription(dr));
                }
                dr.Dispose();
            }
            return lst;
        }

        public void Enregistrer(IInscription membre)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_INSCRIPTION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_membre", 4, DbType.Int32, RefMembre));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_round", 4, DbType.Int32, RefRound));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@user_session", 30, DbType.String, UserSession));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Inscription";
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

        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE_INSCRIPTION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private IInscription GetAllDetailsInscription(IDataReader rd)
        {
            IInscription ins = new Inscription();

            i = i + 1;

            ins.Num = i;
            ins.Id = Convert.ToInt32(rd["Id"].ToString());
            ins.DateInscrit = Convert.ToDateTime(rd["Date_Inscription"].ToString());
            ins.RefMembre= Convert.ToInt32(rd["IdMembre"].ToString());
            ins.Matricule = rd["Matricule"].ToString();
            ins.NomComplet = rd["Nom_Complet"].ToString();
            ins.Nom= rd["Nom"].ToString();
            ins.Postnom= rd["Postnom"].ToString();
            ins.Prenom= rd["Prenom"].ToString();
            ins.Sexe = rd["Sexe"].ToString().Equals("M") ? Sexe.Masculin : Sexe.Féminin;
            ins.RefRound= Convert.ToInt32(rd["IdRound"].ToString());
            ins.Designation = rd["Designation"].ToString();

            return ins;
        }
    }
}
