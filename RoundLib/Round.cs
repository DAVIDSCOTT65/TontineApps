using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundLib
{
    public class Round
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }
        public int RefDetail { get; set; }
        public  int Nouveau()
        {

            return Id;
        }
        public void Enregistrer(Round r)
        {

        }
        public void Supprimer(int id)
        {

        }
    }
}
