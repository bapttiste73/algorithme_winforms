using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    public class Logique
    {
        public const string CLE = "ISTIL";

        public string OrdreLettreCle(string cle)
        {
            string[] ordre = cle.Split();
            foreach (var lettre in ordre)
            {
                Console.WriteLine(lettre + "-");
            }
            return cle;
        }
    }
}
