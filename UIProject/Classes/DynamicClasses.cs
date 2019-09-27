using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;

namespace UIProject.Classes
{
    public class DynamicClasses
    {
        SqlDataReader dr = null;

        SqlDataAdapter dt = null;
        SqlCommand sql = null;
        SqlConnection con;
        DataSet ds;

        public static DynamicClasses _intance = null;

        public static DynamicClasses GetInstance()
        {
            if (_intance == null)
                _intance = new DynamicClasses();
            return _intance;
        }
        public DataTable call_report(string nomtable, string ref_champ, string nomchamp)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                dt = new SqlDataAdapter("select * from " + nomtable + " where " + ref_champ + " = '" + nomchamp + "'", con);
                ds = new DataSet();
                dt.Fill(ds, nomtable);
                con.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }
        }
        public DataTable recherche_Infromation(string NomTable, string Nom, string Postnom, string Prenom, string recherche)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            con = (SqlConnection)ImplementeConnexion.Instance.Conn;
            sql = new SqlCommand("select * from " + NomTable + " WHERE " + Nom + " LIKE '%" + recherche + "%' or " + Postnom + " LIKE '%" + recherche + "%' or " + Prenom + " LIKE '%" + recherche + "%' ", con);
            dt = null;
            dt = new SqlDataAdapter(sql);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public void retreivePhoto2(string ChampPhoto, string nomTable, string ChampCode, string Valeur, PictureBox pic)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT " + ChampPhoto + " from " + nomTable + " WHERE  " + ChampCode + " = '" + Valeur + "'";
                    dt = new SqlDataAdapter((SqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {
                        MessageBox.Show("Vous devez d'abord effectuer le tirage ");
                    }
                    else
                    {
                        Byte[] buffer = (Byte[])resultat;
                        if(buffer==null)
                            MessageBox.Show("Impossible d'affichager la photo \nVérifier si la date de début du Round Selectionner est déjà arriver \nVérifier si le tirage est déjà fait. \nVérifier si chaque membre possede une photo. \nVérifier si la date d'aujourd'hui appartient à l'inervalle de la semaine encours","Attention",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        else
                        {
                            MemoryStream ms = new MemoryStream(buffer);
                            Image image = Image.FromStream(ms);
                            pic.Image = image;
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void retreivePhoto(string valeur, PictureBox photo)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_PHOTO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 50, DbType.Int32, valeur));

                    dt = new SqlDataAdapter((SqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {
                    }
                    else
                    {
                        //Byte[] buffer = (Byte[])resultat;
                        //MemoryStream ms = new MemoryStream(buffer);
                        //Image image = Image.FromStream(ms);
                        //photo.Image = image;

                    Byte[] buffer = (Byte[])resultat;
                    MemoryStream ms = new MemoryStream(buffer);
                    Image image = Image.FromStream(ms);
                    photo.Image = image;

                }
                }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Cette erreur est survenue lors du chargement de la photo : " + ex.Message);
            }

}

        public void chargeCombo(ComboBox cmb, string nomChamp,string procedure)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public void chargeSemainesCombo(ComboBox cmb, string nomChamp,string procedure)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@idRound", 5, DbType.Int32, InstantRound.GetInstance().Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, InstantSemaine.GetInstance().IdSemaine));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public void chargeNomsCombo(ComboBox cmb, string nomChamp, string procedure)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, InstantRound.GetInstance().Id));
                //cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, InstantSemaine.GetInstance().IdSemaine));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }

        public int retourId(string champCode, string nomTable, string champCondition, string valeur)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select " + champCode + " from " + nomTable + " where " + champCondition + " = '" + valeur + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd[champCode].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public int retourIdM(string valeur1)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select Id  from Affichage_Details_Inscriptions where Nom_Complet = '" + valeur1 + "' And IdRound = '" + InstantRound.GetInstance().Id + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd["Id"].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public int retourIdSemaine(string valeur1)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select Id  from Affichage_Details_Semaine where DebutFin = '" + valeur1 + "' And IdRound = '" + InstantRound.GetInstance().Id + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd["Id"].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public int retourInfoMembre(TextBox champ1, TextBox champ2, TextBox champ3, TextBox champ4, ComboBox champ5, MaskedTextBox champ6, TextBox champ7, TextBox champ8, TextBox champ9, string valeur)
        {
            int identifiant = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select Id,Matricule,Nom,Postnom,Prenom,Sexe,Date_Naissance,Lieu_Naissance,Profession,Noms from Affichage_Details_Adresse_Membre where Nom_Complet = '" + valeur + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = Convert.ToInt32(rd["Id"].ToString());
                    champ1.Text = rd["Matricule"].ToString();
                    champ2.Text = rd["Nom"].ToString();
                    champ3.Text = rd["Postnom"].ToString();
                    champ4.Text = rd["Prenom"].ToString();
                    champ5.Text = rd["Sexe"].ToString();
                    champ6.Text = rd["Date_Naissance"].ToString();
                    champ7.Text = rd["Lieu_Naissance"].ToString();
                    champ8.Text = rd["Profession"].ToString();
                    champ9.Text = rd["Noms"].ToString();

                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
            
        }
        public string retourLastCotisationMembre(Label champ1, Label champ2, int valeur)
        {
            string identifiant = "En ordre";
            DateTime dateco, datenow = new DateTime();
            datenow = DateTime.Now;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT_LAST_COTISATION";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, valeur));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@idRound", 5, DbType.Int32, InstantRound.GetInstance().Id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    dateco = Convert.ToDateTime(rd["Date_Concernee"].ToString());
                    //identifiant = Convert.ToInt32(rd["Id"].ToString());
                    champ1.Text = string.Format("{0}", dateco.ToString("dd/MM/yyyy"));
                    champ2.Text = rd["Designation"].ToString();
                    //champ3.Text = rd["Postnom"].ToString();
                    if(Convert.ToDateTime(champ1.Text)==datenow.Date)
                    {
                        identifiant = "En ordre";
                    }
                    else if(Convert.ToDateTime(champ1.Text) < datenow.Date  )
                    {
                        identifiant = "En retard";
                    }
                    else if(Convert.ToDateTime(champ1.Text) > datenow.Date)
                    {
                        identifiant = "En avance";
                        
                    }
                    

                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;

        }
        public int retourInfoRembMembre(Label champ1, Label champ2, Label champ3, string valeur,PictureBox photo)
        {
            int identifiant = 0;
            int id = 0;
            

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_INFO_REMB";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@noms", 100, DbType.String, valeur));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 5, DbType.Int32, InstantRound.GetInstance().Id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    
                    champ1.Text = rd["DebutFin"].ToString();
                    champ2.Text = rd["Matricule"].ToString();
                    champ3.Text = rd["Mandataire"].ToString();
                    identifiant = Convert.ToInt32(rd["Id"].ToString());
                    id = Convert.ToInt32( rd["IdMembre"].ToString());





                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
                retreivePhoto(id.ToString(), photo);
            }
            return identifiant;

        }
        public int retourStock(string champStock, string nomTable, string champCondition, string valeur)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select " + champStock + " from " + nomTable + " where " + champCondition + " = '" + valeur + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd[champStock].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }

        public int loginTest(string nom, string password)
        {
            int count = 0;
            string username = "";
            string niveau = "";
            string fonction = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@pseudo", 50, DbType.String, nom));
                    cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@pass", 200, DbType.String, password));
                    SqlCommand comande = (SqlCommand)cmd;
                    dr = comande.ExecuteReader();
                    while (dr.Read())
                    {
                        niveau = dr["niveau_acces"].ToString();
                        username = dr["noms"].ToString();
                        fonction = dr["fonction"].ToString();
                        count += 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("La connection a reussie !!!", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserSession.GetInstance().AccessLevel = niveau;
                        UserSession.GetInstance().UserName = username;
                        UserSession.GetInstance().Fonction = fonction;
                    }
                    else
                    {
                        MessageBox.Show("Echec de Connexion.", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return count;
        }

    }
}
