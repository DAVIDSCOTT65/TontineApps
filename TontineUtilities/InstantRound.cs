using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TontineUtilities
{
    public class InstantRound
    {
        private static InstantRound inst;
        public int Id { get; set; }
        public int IdMembre { get; set; }
        public int Limite { get; set; }
        public int Incrit { get; set; }
        
        public string Designation { get; set; }
        public int LimiteInscription()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_LIMIE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, Id));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Limite"] == DBNull.Value)
                        Limite = 0;
                    else
                        Limite = Convert.ToInt32(dr["Limite"].ToString());
                }
                dr.Dispose();
            }

            return Limite;
        }
        public int CountInscription()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_COUNT_MEMBRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, Id));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Nbr"] == DBNull.Value)
                        Incrit = 0;
                    else
                        Incrit = Convert.ToInt32(dr["Nbr"].ToString());
                }
                dr.Dispose();
            }

            return Incrit;
        }

        public static InstantRound GetInstance()
        {
            if (inst == null)
            {
                inst = new InstantRound();
            }

            return inst;
        }
        
    }
}
