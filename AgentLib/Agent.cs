﻿using ManageSingleConnection;
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

namespace AgentLib
{
    public class Agent : IAgent
    {
        public string Adresse { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public int Id { get; set; }
        public string Niveau { get; set; }
        public string Noms { get; set; }
        public string PassWord { get; set; }
        public Image Photo { get; set; }
        public string Pseudo { get; set; }
        public Sexe Sex { get; set; }

        public List<IAgent> AllAgents()
        {
            List<IAgent> lst = new List<IAgent>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_AGENT";
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetAgent(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        public List<IAgent> Research(string NomTable, string Champs1, string Champs2, string Champs3, string recherche)
        {
            List<IAgent> lst = new List<IAgent>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "select * from " + NomTable + " WHERE " + Champs1 + " LIKE '%" + recherche + "%' or " + Champs2 + " LIKE '%" + recherche + "%' or " + Champs3 + " LIKE '%" + recherche + "%' ";
                //cmd.CommandType = CommandType.StoredProcedure;
                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetAgent(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }

        public void Enregistrer(IAgent agent)
        {


            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_AGENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@noms", 100, DbType.String, Noms));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@adresse", 100, DbType.String, Adresse));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@contact", 100, DbType.String, Contact));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@pseudo", 100, DbType.String, Pseudo));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@password", 200, DbType.String, PassWord));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@nivau", 10, DbType.String, Niveau));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, Sex == Sexe.Masculin ? "M" : "F"));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@email", 30, DbType.String, Email));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@fonction", 30, DbType.String, Fonction));
                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@photo", int.MaxValue, DbType.Binary, ConverttoByteImage(Photo)));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistrement reussi !!!", "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }
        private byte[] ConverttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public int Nouveau()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(idagent) as Lastid FROM Agent";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
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
        public IAgent OneAgentDetail(int id)
        {
            IAgent ag = new Agent();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ONE_AGENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "id", 4, DbType.Int32, id));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ag = GetAgent(dr);
                }
                dr.Dispose();
            }
            return ag;
        }
        public void Supprimer(int id)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE_AGENT";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private IAgent GetAgent(IDataReader rd)
        {
            IAgent ag = new Agent();

            ag.Id = Convert.ToInt32(rd["idAgent"].ToString());
            ag.Noms = rd["noms"].ToString();
            ag.Sex = rd["Sexe"].ToString().Equals("M") ? Sexe.Masculin : Sexe.Féminin;
            ag.Adresse = rd["Adresse"].ToString();
            ag.Contact = rd["Contact"].ToString();
            ag.Pseudo = rd["Pseudo"].ToString();
            ag.Niveau = rd["niveau_acces"].ToString();
            ag.Fonction = rd["fonction"].ToString();
            ag.PassWord = rd["pass_word"].ToString();
            ag.Email = rd["email"].ToString();


            return ag;
        }


    }
}
