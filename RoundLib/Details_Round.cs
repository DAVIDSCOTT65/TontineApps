using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundLib
{
    class Details_Round
    {
        public int Id { get; set; }
        public int Ecart_Jour { get; set; }
        public float Montant_Jour { get; set; }
        public string Device { get; set; }
        public int Limite { get; set; }
        public string UserSession { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Details_Round detail)
        {

        }
        public void Supprimer(int id)
        {

        }
    }
}
