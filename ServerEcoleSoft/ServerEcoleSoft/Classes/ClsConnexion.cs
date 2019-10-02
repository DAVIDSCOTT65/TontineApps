using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerEcoleSoft.Classes
{
    class connexion
    {
        public string chemin;

        public void connect()
        {

            pubCon.testFile();

            string Serveur = File.ReadAllText(ClassConstantes.Table.serveur.ToString()).Trim();
            string Database = File.ReadAllText(ClassConstantes.Table.database.ToString()).Trim();
            string User = File.ReadAllText(ClassConstantes.Table.user.ToString()).Trim();
            string Password = File.ReadAllText(ClassConstantes.Table.password.ToString()).Trim();

            chemin = "server = "+ Serveur + ";database = "+ Database + ";uid ="+User + ";pwd = "+ Password + ";";

        }
    }
}
