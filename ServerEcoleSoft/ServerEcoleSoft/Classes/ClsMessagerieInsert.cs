using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerEcoleSoft.Classes
{
    public class ClsMessagerieInsert
    {
        int codeMs;
        string Numero;
        string MessateTexte;
        DateTime DateEvoie;
        int EtatSms;
        long NumeroRecu;
        string Utilisateur;
        public int CodeMs
        {
            get
            {
                return codeMs;
            }

            set
            {
                codeMs = value;
            }
        }

        public string Numero1
        {
            get
            {
                return Numero;
            }

            set
            {
                Numero = value;
            }
        }

        public string MessateTexte1
        {
            get
            {
                return MessateTexte;
            }

            set
            {
                MessateTexte = value;
            }
        }

        public DateTime DateEvoie1
        {
            get
            {
                return DateEvoie;
            }

            set
            {
                DateEvoie = value;
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

        public long NumeroRecu1
        {
            get
            {
                return NumeroRecu;
            }

            set
            {
                NumeroRecu = value;
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
    }
}
