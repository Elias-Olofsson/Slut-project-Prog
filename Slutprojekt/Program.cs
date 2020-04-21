using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography;

namespace Slutprojekt //Det här och över skrev inte jag.
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
    
            app.Start(); //Den här gör så att App startar så att programmet inte slutar här.
        }
    }
    
}
