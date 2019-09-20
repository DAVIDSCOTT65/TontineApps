using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundLib
{
    public class Details_Round
    {
        public int Id { get; set; }
        public int Ecart_Jour { get; set; }
        public decimal Montant_Jour { get; set; }
        public string Devise { get; set; }
        public int Limite { get; set; }
        public string UserSession { get; set; }
        public string Designation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdRound { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Detail_Round";
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
        public void Enregistrer(Details_Round detail)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_DETAIL_ROUND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ecart", 4, DbType.Int32, Ecart_Jour));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@montant", 4, DbType.Decimal, Montant_Jour));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@devise", 20, DbType.String, Devise));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@limite", 4, DbType.Int32, Limite));
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
                cmd.CommandText = "DELETE_DETAIL_ROUND";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Details_Round> AllDetailsRounds()
        {
            List<Details_Round> dr = new List<Details_Round>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ROUNDS";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    dr.Add(GetDetailsRounds(rd));
                }
                rd.Dispose();
            }
            return dr;
        }
        public List<Details_Round> AllDetails()
        {
            List<Details_Round> dr = new List<Details_Round>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_DETAILS";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    dr.Add(GetDetailsRoundsV(rd));
                }
                rd.Dispose();
            }
            return dr;
        }
        private Details_Round GetDetailsRounds(IDataReader rd)
        {
            Details_Round dr = new Details_Round();

            dr.IdRound = Convert.ToInt32(rd["Id"].ToString());
            dr.Designation = rd["Designation"].ToString();
            dr.DateDebut = Convert.ToDateTime(rd["Date_Debut"].ToString());
            dr.DateFin = Convert.ToDateTime(rd["Date_Fin"].ToString());
            dr.Id= Convert.ToInt32(rd["IdDetail"].ToString());
            dr.Montant_Jour= Convert.ToDecimal(rd["Montant_Jour"].ToString());
            dr.Devise = rd["Devise"].ToString();
            dr.Ecart_Jour= Convert.ToInt32(rd["Ecart_Jour"].ToString());
            dr.Limite= Convert.ToInt32(rd["Limite"].ToString());

            return dr;
        }
        private Details_Round GetDetailsRoundsV(IDataReader rd)
        {
            Details_Round dr = new Details_Round();

            
            dr.Id = Convert.ToInt32(rd["Id"].ToString());
            dr.Montant_Jour = Convert.ToDecimal(rd["Montant_Jour"].ToString());
            dr.Devise = rd["Devise"].ToString();
            dr.Ecart_Jour = Convert.ToInt32(rd["Ecart_Jour"].ToString());
            dr.Limite = Convert.ToInt32(rd["Limite"].ToString());

            return dr;
        }
    }
}
