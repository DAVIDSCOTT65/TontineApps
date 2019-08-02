using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotisationLib
{
    public class Frais
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public int RefCateg { get; set; }
        public int Nouveau()
        {
            return Id;
        }
        public void Enregistrer(Frais fr)
        {

        }
        public void Supprimer(int id)
        {

        }
        public List<Frais> AllFrais()
        {

            throw new NotImplementedException();
        }
    }
}
