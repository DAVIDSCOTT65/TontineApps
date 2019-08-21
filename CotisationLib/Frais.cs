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
    public class Frais
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public int RefCateg { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Type_Frais";
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
        public void Enregistrer(Frais fr)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_TYPE_FRAIS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@designation", 30, DbType.String, Designation));

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
                cmd.CommandText = "DELETE_FRAIS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Frais> AllFrais()
        {

            throw new NotImplementedException();
        }
    }
}
