using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembreLib
{
    public class Domicile
    {
        public int Id { get; set; }
        public string Avenue { get; set; }
        public string Numero { get; set; }
        public int RefAdresse { get; set; }
        public int RefMembre { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public string Commune { get; set; }
        public string Quartier { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Domicile";
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
        public void Enregistrer(Domicile d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_DOMICILE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@avenue", 30, DbType.String, Avenue));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@numero", 30, DbType.String, Numero));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_adresse", 4, DbType.Int32, RefAdresse));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_membre", 30, DbType.String, RefMembre));

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
                cmd.CommandText = "DELETE_DOMICILE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));


                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Domicile> AllAdresses()
        {
            List<Domicile> lst = new List<Domicile>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MEMBRES";
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, idround));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetAllAdresse(dr));
                }
                dr.Dispose();
            }
            return lst;
        }

        private Domicile GetAllAdresse(IDataReader dr)
        {
            Domicile m = new Domicile();

            m.RefAdresse = Convert.ToInt32(dr["IdAdresse"].ToString());
            m.Pays = dr["Pays"].ToString();
            m.Ville = dr["Ville"].ToString();
            m.Commune = dr["Commune"].ToString();
            m.Quartier = dr["Quartier"].ToString();
            m.Avenue = dr["Avenue"].ToString();
            
            return m;
        }

    }
}
