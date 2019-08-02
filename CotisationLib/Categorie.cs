using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotisationLib
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Categorie cat)
        {

        }
        public void Supprimer(int id)
        {

        }
    }
}
