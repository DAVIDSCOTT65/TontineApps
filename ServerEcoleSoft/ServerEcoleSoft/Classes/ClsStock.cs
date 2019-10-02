using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerEcoleSoft.Classes
{
    class ClsStock
    {
        int code;
        int RefArticle;
        double quantite;
        DateTime dateSock;

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

        public int RefArticle1
        {
            get
            {
                return RefArticle;
            }

            set
            {
                RefArticle = value;
            }
        }


        public DateTime DateSock
        {
            get
            {
                return dateSock;
            }

            set
            {
                dateSock = value;
            }
        }

        public double Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }
    }
}
