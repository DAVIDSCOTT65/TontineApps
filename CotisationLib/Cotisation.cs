using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotisationLib
{
    public class Cotisation
    {
        public int Id { get; set; }
        public int RefInscription { get; set; }
        public int RefRemboursement { get; set; }
        public DateTime DateCotisation { get; set; }
        public DateTime DateConcernee { get; set; }
        public float Montant { get; set; }
        public int RefFrais { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Cotisation cot)
        {

        }
        public void Supprimer(int id)
        {

        }
        public List<Cotisation> AllCotisationDay()
        {
            throw new NotImplementedException();
        }
        public List<Cotisation> AllCotisationSemaine(int idRemb)
        {
            throw new NotImplementedException();
        }
    }
}
