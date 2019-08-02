using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemboursementLib
{
    public class Semaine
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Semaine sem)
        {

        }
        public void Supprimer(int id)
        {

        }
        public List<Semaine> AllSemaines()
        {
            throw new NotImplementedException();
        }
    }
}
