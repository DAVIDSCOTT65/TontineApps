using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreLib
{
    public class Domicile
    {
        public int Id { get; set; }
        public string Avenue { get; set; }
        public string Numero { get; set; }
        public int RefAdresse { get; set; }
        public int RefMembre { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Domicile d)
        {

        }
        public void Supprimer(int id)
        {

        }

    }
}
