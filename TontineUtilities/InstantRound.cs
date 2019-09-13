using ManageSingleConnection;
using ParametreConnexionLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TontineUtilities
{
    public class InstantRound
    {
        private static InstantRound inst;
        public int Id { get; set; }
        public int IdMembre { get; set; }
        
        public string Designation { get; set; }
        
        public static InstantRound GetInstance()
        {
            if (inst == null)
            {
                inst = new InstantRound();
            }

            return inst;
        }
        
    }
}
