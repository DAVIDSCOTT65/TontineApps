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
    public class Telephone
    {
        public int Id { get; set; }
        public string Initial { get; set; }
        public string Numero { get; set; }
        public int RefMembre { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Telephone";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
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
        public void Enregistrer(Telephone a)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_TELEPHONE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@initial", 30, DbType.String, Initial));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@numero", 30, DbType.String, Numero));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_membre", 30, DbType.String, RefMembre));

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE_TELEPHONE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
