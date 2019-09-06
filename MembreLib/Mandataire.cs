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
    public class Mandataire
    {
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Contat { get; set; }
        public string Profession { get; set; }
        public DateTime DateNaiss { get; set; }
        public int Age { get; set; }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Mandataire";
                IDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
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
        public void Enregistrer(Mandataire m)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MANDATAIRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@noms", 100, DbType.String, Noms));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@contact", 100, DbType.String, Contat));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@profession", 100, DbType.String, Profession));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@date_naiss", 10, DbType.Date, DateNaiss));

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
                cmd.CommandText = "DELETE_MANDATAIRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Mandataire> AllMandataire()
        {
            List<Mandataire> manda = new List<Mandataire>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MANDATAIRES";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    manda.Add(GetAllMandataire(rd));
                }
                rd.Dispose();
            }
            return manda;
        }
        private Mandataire GetAllMandataire(IDataReader rd)
        {
            Mandataire m = new Mandataire();

            m.Id = Convert.ToInt32(rd["Id"].ToString());
            m.Noms = rd["Noms"].ToString();
            m.Contat = rd["Contact"].ToString();
            m.Profession = rd["Profession"].ToString();
            m.Age= Convert.ToInt32(rd["Age"].ToString());

            return m;
        }
    }
}
