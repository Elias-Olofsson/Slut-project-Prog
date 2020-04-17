using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt //Det här och över skrev inte jag.
{
    class Formel //Jag har redan gjort det här men utan class så nu gör jag det med class.
    {
        private string namn; //Här är properties.
        private string formeln;

        public string Namn { get {return namn; } set {namn = value; } } //Dessa gör så att man kan använda propertiesarna på andra sidan.
        public string Formeln { get { return formeln; } set { formeln = value; } }
    }
}
