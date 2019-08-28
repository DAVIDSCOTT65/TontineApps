using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MembreLib
{
    public interface IMembre
    {
        int Id { get; set; }
        string Matricule { get; set; }
        string Nom { get; set; }
        string Postnom { get; set; }
        string Prenom { get; set; }
        Sexe Sex { get; set; }
        DateTime DateNaiss { get; set; }
        string LieuNaiss { get; set; }
        string Profession { get; set; }
        Image Photo { get; set; }
        Image QrCode { get; set; }
        int RefMandataire { get; set; }
        string Noms { get; set; }
        string Contact { get; set; }
        int IdAdresse { get; set; }
        string Pays { get; set; }
        string Ville { get; set; }
        string Commune { get; set; }
        string Quartier { get; set; }
        int IdDomicile { get; set; }
        string Avenue { get; set; }
        int Numero { get; set; }
        int Nouveau();
        void Enregistrer(IMembre membre);
        void Supprimer(int id);
        List<IMembre> AllMembres();


    }
}
