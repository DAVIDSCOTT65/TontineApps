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
    public class ClsSMS
    {
        int i;
        int code;
        string NumeroTutaire;
        string CorpsMessage, DateEnvoie;
        int EtatSms;
        string Utilisateur;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string NumeroTutaire1
        {
            get
            {
                return NumeroTutaire;
            }

            set
            {
                NumeroTutaire = value;
            }
        }

        public string CorpsMessage1
        {
            get
            {
                return CorpsMessage;
            }

            set
            {
                CorpsMessage = value;
            }
        }

        public string DateEnvoie1
        {
            get
            {
                return DateEnvoie;
            }

            set
            {
                DateEnvoie = value;
            }
        }

        public int EtatSms1
        {
            get
            {
                return EtatSms;
            }

            set
            {
                EtatSms = value;
            }
        }

        public string Utilisateur1
        {
            get
            {
                return Utilisateur;
            }

            set
            {
                Utilisateur = value;
            }
        }
        int Num { get; set; }
        public List<ClsSMS> AllSms()
        {
            List<ClsSMS> lst = new List<ClsSMS>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_SMS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AjouterParametre(cmd, "@usersession", 30, DbType.String, UserSession.GetInstance().UserName));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetSMS(rd));
                }
                rd.Dispose();
            }
            return lst;
        }
        private ClsSMS GetSMS(IDataReader rd)
        {
            ClsSMS sms = new ClsSMS();

            i = i + 1;

            sms.Num = i;
            sms.Code = Convert.ToInt32(rd["id"].ToString());
            sms.NumeroTutaire = rd["NumeroTutaire"].ToString();
            sms.CorpsMessage = rd["CorpsMessage"].ToString();
            sms.EtatSms = Convert.ToInt32(rd["EtatSms"].ToString());
            sms.DateEnvoie = rd["DateEnvoie"].ToString();
            sms.Utilisateur = rd["UserSession"].ToString();

            return sms;
        }
    }
}
