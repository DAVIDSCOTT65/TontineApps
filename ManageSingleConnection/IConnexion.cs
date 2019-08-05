using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnection
{
    internal interface IConnexion
    {
        IDbConnection Initialise(Connexion connexion, ConnexionType connectionType);
    }
}
