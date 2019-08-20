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
        public DateTime DateNaiss
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string LieuNaiss
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
         public string Matricule
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string Nom
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public Image Photo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string Postnom
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string Prenom
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string Profession
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public Image QrCode
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public int RefMandataire
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public Sexe Sex
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public List<IMembre> AllMembres()
        {
            throw new NotImplementedException();
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
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@qrcode", 4, DbType.Binary, converttoByteImage(QrCode)));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@photo", 4, DbType.Binary, converttoByteImage(Photo)));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@ref_mandataire", 4, DbType.Int32, RefMandataire));

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
    }
}
