using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembreLib
{
    public class Membre : IMembre
    {
        public string Avenue { get; set; }

        public string Commune { get; set; }

        public string Contact { get; set; }

        public DateTime DateNaiss { get; set; }
        public int Id { get; set; }
        

        public int IdAdresse { get; set; }

        public int IdDomicile { get; set; }

        public string LieuNaiss { get; set; }
         public string Matricule { get; set; }
        public string Nom { get; set; }

        public string Noms { get; set; }

        public int Numero { get; set; }

        public string Pays { get; set; }

        public Image Photo { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Profession { get; set; }
        public Image QrCode { get; set; }

        public string Quartier { get; set; }

        public int RefMandataire { get; set; }
        public Sexe Sex { get; set; }

        public string Ville { get; set; }

        public List<IMembre> AllMembres()
        {
            List<IMembre> membre = new List<IMembre>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MEMBRES";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    membre.Add(GetAllDetailsMembre(dr));
                }
            }
            return membre;
        }
        public void Enregistrer(IMembre membre)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MEMBRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@matricule", 30, DbType.String, Matricule));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, Nom));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@postnom", 50, DbType.String, Postnom));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@prenom", 50, DbType.String, Prenom));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, Sex == Sexe.Féminin ? "F" : "M"));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@date_naiss", 10, DbType.Date, DateNaiss));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@lieu_naiss", 20, DbType.String, LieuNaiss));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@profession", 50, DbType.String, Profession));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@qrcode", int.MaxValue, DbType.Binary, converttoByteImage(QrCode)));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@photo", int.MaxValue, DbType.Binary, converttoByteImage(Photo)));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_mandataire", 4, DbType.Int32, RefMandataire));

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Enregistrement reussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(id) as Lastid FROM Membre";
                IDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    if (dr["Lastid"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(dr["Lastid"].ToString()) + 1;
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
                cmd.CommandText = "DELETE_MEMBRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppression effectuée", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private byte[] converttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        private IMembre GetAllDetailsMembre(IDataReader dr)
        {
            IMembre m = new Membre();

            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Matricule = dr["Matricule"].ToString();
            m.Nom= dr["Nom"].ToString();
            m.Postnom= dr["Postnom"].ToString();
            m.Prenom= dr["Prenom"].ToString();
            m.Sex= dr["Sexe"].ToString().Equals("M") ? Sexe.Masculin : Sexe.Féminin;
            m.DateNaiss = Convert.ToDateTime(dr["Date_Naissance"].ToString());
            m.LieuNaiss= dr["Lieu_Naissance"].ToString();
            m.Profession = dr["Profession"].ToString();
            m.RefMandataire = Convert.ToInt32(dr["IdMandataire"].ToString());
            m.Noms = dr["Noms"].ToString();
            m.Contact = dr["Contact"].ToString();
            m.IdAdresse = Convert.ToInt32(dr["IdAdresse"].ToString());
            m.Pays= dr["Pays"].ToString();
            m.Ville = dr["Ville"].ToString();
            m.Commune = dr["Quartier"].ToString();
            m.IdDomicile = Convert.ToInt32(dr["IdDomicile"].ToString());
            m.Avenue= dr["Avenue"].ToString();
            m.Numero = Convert.ToInt32(dr["Numero"].ToString());

            return m;
        }
    }
}
