using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CommunicationSoft.Classes;
using System.Data.SqlClient;

namespace ServerEcoleSoft.Classes
{
    class ClsGlossiaires
    {
        connexion cnx = null;
        private static ClsGlossiaires glos;
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;
        SqlDataReader dr = null;
       
        public void innitialiseConnect()
        {
            try
            {
                cnx = new connexion();
                cnx.connect();
                con = new SqlConnection(cnx.chemin);
            }
            catch (Exception)
            {
                throw new Exception("l'un de vos fichiers de configuration est incorrect");
            }

        }
        public static ClsGlossiaires GetInstance()
        {
            if (glos == null)
                glos = new ClsGlossiaires();
            return glos;
        }
        private static void setParameter(SqlCommand cmd, string name, DbType type, int length, object paramValue)
        {
            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;
            cmd.Parameters.Add(a);
        }
       
        public DataTable chargementMessagerie()
        {
            DataTable table = new DataTable();
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                dt = new SqlDataAdapter("select * from Messagerie where EtatSms= 0 ", con);
                dt.Fill(table);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            return table;
        }

        public void backupBD()
        {

            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                string database = con.Database.ToString();

                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + ClassConstantes.Table.CheminBackup + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    //XtraMessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        public void update_Valmsg(string code)
        {
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("delete from Messagerie where id=@id ", con);
                cmd.Parameters.AddWithValue("@id", code);                
                cmd.ExecuteNonQuery();              

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        

        ClsMessages ms = new ClsMessages();
         public void EnvoiMessagePlusieur(DataGridView Grid) {
            string touNum = "";
            string touMessage = "";
            string toutCode = "";

            if (Grid.Rows.Count > 0)
            {
                for (int i = 0; i < (Grid.Rows.Count) ; i++)
                {
                    touNum = Grid[1, i].Value.ToString();
                    touMessage = Grid[2, i].Value.ToString();
                    toutCode= Grid[0, i].Value.ToString();
                    if (touMessage.Length <= 140)
                    {
                        if (ms.sendlongMsg(touNum, touMessage + "                                                    "))
                        {
                            update_Valmsg(toutCode);
                            Grid.Rows.RemoveAt(i);
                        }
                        else {
                            MessageBox.Show("Un Message non envoye !!!!!");
                        }
                       
                        
                    }
                    else
                    {
                        if (ms.sendlongMsg(touNum, touMessage))
                        {
                            update_Valmsg(toutCode);
                            Grid.Rows.RemoveAt(i);
                        }
                        else
                        {
                            MessageBox.Show("Un Message non envoye !!!!!");
                        }

                    }


                }

            }
            else {
                MessageBox.Show("Pas de Message svp !!!");
            }
            
            
        }

        public void insert_SMS(ClsSMS cb)
        {
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                
                cmd = new SqlCommand("insert into tMessagerie(NumeroTutaire,CorpsMessage,DateEnvoie,EtatSms,Utilisateur) values (@NumeroTutaire,@CorpsMessage,@DateEnvoie,@EtatSms,@Utilisateur)", con);
                cmd.Parameters.AddWithValue("@NumeroTutaire", cb.Numero);
                cmd.Parameters.AddWithValue("@CorpsMessage", cb.CorpsMsg);
                cmd.Parameters.AddWithValue("@DateEnvoie", cb.DateEnvoie);
                cmd.Parameters.AddWithValue("@EtatSms", cb.EtatSMS);
                cmd.Parameters.AddWithValue("@Utilisateur", cb.User);
                cmd.ExecuteNonQuery();

                //DialogResult res = MessageBox.Show("voulez vous vraiment enregistrer cette operation?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (res == DialogResult.Yes)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Opération Annulée!");

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        public DataTable chargement_Messagerie1(string Nomtable, string Nom, string Numero, TextBox txt)
        {
            innitialiseConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select " + Nom + "," + Numero + " from Affichage_Details_Inscriptions WHERE contact like '+2439%' or contact like '09%' ", con);
            dt.Fill(table);
            con.Close();
            return table;
        }

        public DataTable chargement_Messagerie2(string Nomtable, string Nom, string Numero, TextBox txt)
        {
            innitialiseConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select " + Nom + "," + Numero + " from customer WHERE contact like '+2438%' or contact like '08%' ", con);
            dt.Fill(table);
            con.Close();
            return table;
        }

        public DataTable chargement_Messagerie(string Nomtable, string Nom, string Numero,TextBox txt)
        {
            innitialiseConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select " + Nom + "," + Numero + " from Affichage_Details_Inscriptions WHERE Contact !=  '-' and Nom_Complet like '%" + txt.Text+ "%' or Contact like '%" + txt.Text + "%' ", con);
            dt.Fill(table);
            con.Close();
            return table;
        }


        public DataTable chargement_Messagerie(string Nomtable, string Nom, string Numero)
        {
            innitialiseConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select " + Nom + "," + Numero + " from " + Nomtable + " WHERE contact !=  '-' ", con);
            dt.Fill(table);
            con.Close();
            return table;
        }

        public void SendMessagePaiement()
        {
            bool envoie = true;
            string numero = "";
            string message = "";            
            string codeMs = "";
            string utilisateur = "";
            string dateEnvoie = "" ;
            string Etat = "";
            int count = 0;
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Messagerie WHERE EtatSms = 0 ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    numero = dr["NumeroTutaire"].ToString();
                    message = dr["CorpsMessage"].ToString();                    
                    codeMs = dr["id"].ToString();
                    dateEnvoie = dr["DateEnvoie"].ToString();
                    utilisateur = dr["Utilisateur"].ToString();
                    Etat = dr["EtatSms"].ToString();

                    if (numero != "" && message != "" && count!=1)
                    {
                        ClsMessages ms = new ClsMessages();
                        if (message.Length <= 140)
                        {
                            update_Valmsg(codeMs);
                            if (ms.sendshortMsg(numero, message) == false)
                            {
                                if (ms.sendlongMsg(numero, message + "                                                   ") == false) {
                                    envoie = false;
                                    ClsMessagerieInsert msInsert = new ClsMessagerieInsert();
                                    msInsert.Numero1 = numero;
                                    msInsert.MessateTexte1 = message;
                                    msInsert.DateEvoie1 = DateTime.Parse(dateEnvoie);
                                    msInsert.EtatSms1 = 0;
                                    msInsert.Utilisateur1 = utilisateur;
                                    ClsGlossiaires.GetInstance().insertMessagerie(msInsert);

                                    numero = "";
                                    message = "";
                                    codeMs = "";
                                    dateEnvoie = "";
                                    utilisateur = "";
                                    Etat = "";
                                }
                                
                            }
                            else {
                                envoie = true;
                                numero = "";
                                message = "";
                                codeMs = "";
                                dateEnvoie = "";
                                utilisateur = "";
                                Etat = "";
                            }
                            
                            
                        }
                        else {
                            update_Valmsg(codeMs);
                            if (ms.sendlongMsg(numero, message) == true)
                            {
                                numero = "";
                                message = "";
                                envoie = true;
                            }
                            else {
                                envoie = false;

                                ClsMessagerieInsert msInsert = new ClsMessagerieInsert();
                                msInsert.MessateTexte1 = message;
                                msInsert.DateEvoie1 = DateTime.Parse(dateEnvoie);
                                msInsert.EtatSms1 = 0;
                                msInsert.Utilisateur1 = utilisateur;
                                ClsGlossiaires.GetInstance().insertMessagerie(msInsert);
                            }
                            
                        }                        
                        //update set statutMessage='non'
                        

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                envoie = false;

                ClsMessagerieInsert msInsert = new ClsMessagerieInsert();
                msInsert.MessateTexte1 = message;
                //msInsert.DateEvoie1 = DateTime.Parse(dateEnvoie);
                msInsert.EtatSms1 = 0;
                msInsert.Utilisateur1 = utilisateur;
                ClsGlossiaires.GetInstance().insertMessagerie(msInsert);
            }
            con.Close();

            //return envoie;
        }

        public void insertMessagerie(ClsMessagerieInsert cb)
        {

            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("insert into Messagerie values (@NumeroTutaire,@CorpsMessage,@DateEnvoie,@EtatSms,@Utilisateur)", con);
                setParameter(cmd, "@NumeroTutaire", DbType.String, 20, cb.Numero1);
                setParameter(cmd, "@CorpsMessage", DbType.String, 500, cb.MessateTexte1);
                setParameter(cmd, "@DateEnvoie", DbType.DateTime, 20, cb.DateEvoie1);
                setParameter(cmd, "@EtatSms", DbType.Int32, 90, cb.EtatSms1);
                setParameter(cmd, "@Utilisateur", DbType.String, 90, cb.Utilisateur1);
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Envoie du message pris en charge par le serveur !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void insertStock(ClsStock cb)
        {

            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("exec InsertSI @Article,@Quantite,@DateStock", con);
                setParameter(cmd, "@Article", DbType.String, 20, cb.RefArticle1);
                setParameter(cmd, "@Quantite", DbType.String, 500, cb.Quantite);
                setParameter(cmd, "@DateStock", DbType.DateTime, 20, cb.DateSock);
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Message Envoyé ");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void InsertArticleSI()
        {
            bool teste = true;
            ClsStock cb = new ClsStock();
            innitialiseConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select codeArt,quantiteArt from tArticle", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                cb.RefArticle1 = int.Parse(dr["codeArt"].ToString());
                cb.Quantite = double.Parse(dr["quantiteArt"].ToString());
                cb.DateSock = DateTime.Now;
                insertStock(cb);
                //count += 1;

            }
            //if (count == 1)
            //{
            //    teste = true;
            //}

            //else
            //{
            //    teste = false;
            //}

            //return teste;

        }








    }
}
