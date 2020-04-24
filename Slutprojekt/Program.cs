using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography;

namespace Slutprojekt //Det här och över skrev inte jag men det blev fel när jag tog bort dem..
{
    class Program //Jag kanske skulle sätta denna som private men jag vet inte vad det skulle göra i längden. Jag testade snabbt och det funkade en kort bit. The main part är ju redan private så jag känner mig inte lika övertygad att göra det.
    {
        private static void Main(string[] args) //Jag tänkte att ni ville ha saker private så kanske det blir säkrare om main är private. Det verkar inte göra någon större skillnad men mitt logiska tänkande säger att eftersom ni går efter engelskan så kanske main är en stor eller viktig del. If the main area is not secure then the place is not secure. Jag vet dock inte om det gör det säkrare men engelskans private är svenskans privat och privata ägande skyddas i grundlagen och språken tar ord och dess meningar från vanliga språk. Är jag ottydlig bara mejla.
        {
            App app = new App();
    
            app.Start(); //Den här gör så att App startar så att programmet inte slutar här.
        }
    }
}
