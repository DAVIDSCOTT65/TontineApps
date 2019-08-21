using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscriptionLib
{
    public interface IInscription
    {
        int Id { get; set; }
        int RefMembre { get; set; }
        int RefRound { get; set; }
        string UserSession { get; set; }
        int Nouveau();
        void Enregistrer(IInscription membre);
        void Supprimer(int id);
        List<IInscription> AllInscriptionsRound(int idround);
        
    }
}
