﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt //Det här och över skrev inte jag.
{
    class Formel //Jag har redan gjort det här men utan class så nu gör jag det med class.
    {
        private string namn; //Private för att ni ville ha privata variabler.
        private string formeln;
        public string Namn { get {return namn; } set {namn = value; } } //Dessa gör så att man kan använda propertiesarna på andra sidan i App.
        public string Formeln { get { return formeln; } set { formeln = value; } } // Dessa är public för att annars komms den inte åt som den ska.
    }
}
