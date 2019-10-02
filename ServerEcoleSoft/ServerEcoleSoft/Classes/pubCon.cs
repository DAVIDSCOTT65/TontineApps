using GsmComm.GsmCommunication;
using ServerEcoleSoft.Formulaires;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEcoleSoft.Classes
{
    class pubCon
    {
        public static String connec;
        public static String dataS;
        public static String initcat;
        public static String id;
        public static String pass;
        public static String niveau;
        public static int etat=0;
        //===================
        public static int testlog;
        public static String codfact;
        public static string codrec;
        //==================
        //public static clsPartenaire part1;
        //public static clsDebiteur deb1;
        //public static clsCredit cred1;
        //public static clsValidationCredit VC1;
        //public static clsValidationObserv VO1;
        //=========sms==============
        public static int port;
        public static int baudRate;
        public static int timeout;
        public static GsmCommMain comm;

        public static void testFile()
        {
            if (Directory.Exists(ClassConstantes.Table.InitialDirectory) == true) { }

                       
            else
            {
                FormConfig frm = new FormConfig();
                frm.ShowDialog();
            }
        }
    }
}
