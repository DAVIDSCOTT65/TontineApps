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
    public class InstantSemaine
    {
        private static InstantSemaine inst;
        public int IdSemaine { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string NomComplet { get; set; }

        public void OneSemaine(int id)
        {
            InstantSemaine ist = new InstantSemaine();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_DETAILS_SEMAINE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ist.IdSemaine = Convert.ToInt32(dr["Id"].ToString());
                    ist.DateDebut = Convert.ToDateTime(dr["Date_Debut"].ToString());
                    ist.DateFin = Convert.ToDateTime(dr["Date_Fin"].ToString());
                    ist.NomComplet = dr["Nom_Complet"].ToString();
                }

                dr.Dispose();
            }

            //return semaine;
        }
        private InstantSemaine GetSemaine(IDataReader dr)
        {
            InstantSemaine ist = new InstantSemaine();

            ist.IdSemaine = Convert.ToInt32(dr["Id"].ToString());
            ist.DateDebut = Convert.ToDateTime(dr["Date_Debut"].ToString());
            ist.DateFin = Convert.ToDateTime(dr["Date_Fin"].ToString());
            ist.NomComplet = dr["Nom_Complet"].ToString();

            return ist;


        }
        public static InstantSemaine GetInstance()
        {
            if (inst == null)
            {
                inst = new InstantSemaine();
            }

            return inst;
        }
    }
}
