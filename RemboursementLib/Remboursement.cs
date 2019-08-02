using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemboursementLib
{
   public  class Remboursement
    {
        public int Id { get; set; }
        public int RefInscription { get; set; }
        public int RefSemaine { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Remboursement remb)
        {

        }
        public void Supprimer(int id)
        {

        }
        public List<Remboursement> AllRemboursements()
        {
            throw new NotImplementedException();
        }
    }
}
