using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSoft.Classes
{
    class ClsSMS
    {
        int etatSMS;
        string numero, corpsMsg;
        string user;
        DateTime dateEnvoie;
        public string CorpsMsg
        {
            get
            {
                return corpsMsg;
            }

            set
            {
                corpsMsg = value;
            }
        }

        public int EtatSMS
        {
            get
            {
                return etatSMS;
            }

            set
            {
                etatSMS = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public DateTime DateEnvoie
        {
            get
            {
                return dateEnvoie;
            }

            set
            {
                dateEnvoie = value;
            }
        }
    }
}
