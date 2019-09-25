using MembreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscriptionLib
{
    public interface IInscription
    {
        int Num { get; set; }
        int Id { get; set; }
        int RefMembre { get; set; }
        int RefRound { get; set; }
        DateTime DateInscrit { get; set; }
        string Matricule { get; set; }
        string NomComplet
        {
            get; set;
        }
        string Nom { get; set; }
        string Postnom { get; set; }
        string Prenom { get; set; }
        Sexe Sexe { get; set; }
        string Designation { get; set; }
        string UserSession { get; set; }
        int Nouveau();
        void Enregistrer(IInscription membre);
        void Supprimer(int id);
        List<IInscription> AllInscriptionsRound(int idround);
        
    }
}
