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
        public float Montant { get; set; }
        public int RefFrais { get; set; }
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
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@montant", 4, DbType.Decimal, Montant));
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
        public List<Cotisation> AllCotisationDay()
        {
            throw new NotImplementedException();
        }
        public List<Cotisation> AllCotisationSemaine(int idRemb)
        {
            throw new NotImplementedException();
        }
    }
}
