using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt
{
    class Formel //Jag har redan gjort det här men utan class så nu gör jag det med class.
    {
        private string namn;
        private string formeln;

        public string Namn { get {return namn; } set {namn = value; } }
        public string Formeln { get { return formeln; } set { formeln = value; } }
    }
}
