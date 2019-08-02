using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreLib
{
    public class Mandataire
    {
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Contat { get; set; }
        public DateTime DateNaiss { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Mandataire m)
        {

        }
        public void Supprimer(int id)
        {
            
        }
        public List<Mandataire> AllMandataire()
        {
            throw new NotImplementedException();
        }
    }
}
