using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreLib
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Quartier { get; set; }
        public string Commune { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Adresse a)
        {

        }
        public void Supprimer(int id)
        {

        }
    }
}
