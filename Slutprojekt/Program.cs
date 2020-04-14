using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Start();
        }
    }
    class App
    {
        public string svar = "Inte valt ännu.";
        Formel a1 = new Formel();
        Formel a2 = new Formel();
        Formel a3 = new Formel();
        Formel b1 = new Formel();
        Formel b2 = new Formel();
        Formel b3 = new Formel();
        Formel c1 = new Formel();
        Formel c2 = new Formel();
        Formel c3 = new Formel();
        Formel d1 = new Formel();
        Formel d2 = new Formel();
        Formel d3 = new Formel();
        Formel e1 = new Formel();
        Formel e2 = new Formel();
        Formel e3 = new Formel(); //Dessa är kanske lite svårare och onödiga men jag motivrar det med att jag vill ha properties som jag egentligen inte behöver men det står att jag ska ha det och det ser lite mer tydligt ut att de är formler.
        public void Start() //Denna är public men den gör så att Input som är private körs.
        {
            a1.Namn = "a1";
            a1.Formeln = "x*2";

            a2.Namn = "a2";
            a2.Formeln = "(x*2)+1";

            a3.Namn = "a3";
            a3.Formeln = "x+2";

            b1.Namn = "b1";
            b1.Formeln = "x*4.5";

            b2.Namn = "b2";
            b2.Formeln = "x*93.4";

            b3.Namn = "b3";
            b3.Formeln = "x*22.8";

            c1.Namn = "c1";
            c1.Formeln = "3.4";

            c2.Namn = "c2";
            c2.Formeln = "(x-1)*x";

            c3.Namn = "c3";
            c3.Formeln = "x*(-1.63)";

            d1.Namn = "d1";
            d1.Formeln = "((x-1)*(x-1)*(x-1))+x";

            d2.Namn = "d2";
            d2.Formeln = "(x*3.4)+4.3";

            d3.Namn = "d3";
            d3.Formeln = "(x-3.4)*x";

            e1.Namn = "e1";
            e1.Formeln = "((x-3.4)*(x-3.4)*(x-3.4))+(x*4.3)";

            e2.Namn = "e2";
            e2.Formeln = "(((x*4.3))-(x*3.4))-3.4";

            e3.Namn = "e3";
            e3.Formeln = "(x*999998999999999999)/(x*2)";

            Input();
        }

        private void Input()
        {
            bool inteKorrekt = true;
            Console.WriteLine("Hej och välkommen till Vad gör programmet med talet?! \nDu får börja att välja en formel och det gör du genom att skriva en bokstav först mellan a och e och ett tal sedan mellan 1 och 3. \nBokstaven är svårighetsgraden där a är lättast och siffran är vilket av talen. Skriv alltid med bara små bokstäver och gör inga mellanrum.\nTryck enter efter varje inmatning och kom ihåg: de högre svårighetsgraderna är riktigt irriterande.");
                        //Här förklaras början för användaren.
            while (inteKorrekt) //While funkar oftare än if så det är för säkerhets skull om jag skulle ändra senare.
            {
                inteKorrekt = false;
                string upgift = Console.ReadLine();
                switch (upgift) //Elias sa att det var så man gjorde det och det ser mindre ut så därför gjorde jag det.
                {
                    case "a1":
                        svar = a1.Formeln;
                        break;
                    case "a2":
                        svar = a2.Formeln;
                        break;
                    case "a3":
                        svar = a3.Formeln;
                        break;
                    case "b1":
                        svar = b1.Formeln;
                        break;
                    case "b2":
                        svar = b2.Formeln;
                        break;
                    case "b3":
                        svar = b3.Formeln;
                        break;
                    case "c1":
                        svar = c1.Formeln;
                        break;
                    case "c2":
                        svar = c2.Formeln;
                        break;
                    case "c3":
                        svar = c3.Formeln;
                        break;
                    case "d1":
                        svar = d1.Formeln;
                        break;
                    case "d2":
                        svar = d2.Formeln;
                        break;
                    case "d3":
                        svar = d3.Formeln;
                        break;
                    case "e1":
                        svar = e1.Formeln;
                        break;
                    case "e2":
                        svar = e2.Formeln;
                        break;
                    case "e3":
                        svar = e3.Formeln;
                        break;
                    default:
                        inteKorrekt = true;
                        break;
                }
                Console.WriteLine("Nu får du börja skriva in tal eller gissningar! \nVill du testa ett tal och se vad det blir skriver du in talet. Vill du gissa så skriver du g."); 
                //Här förklaras fortsättningen för användaren.
                bool svaratRätt = false;
                while (svaratRätt == false)
                {
                    string gEllerEj = Console.ReadLine();
                    if (gEllerEj == "g")
                    {
                        Console.WriteLine("Du har valt att gissa skriv in formeln du gissar! \nOm formeln har en variabel så skriv den som x. Skriv paranteser runt varje uträkning som prioriteras före någon annan uträkning. \nBörja med x om det är ett x. Använd bara de fyra räknesätten och de måste vara utskrivna helt. \nOm det finns olika sätt att skriva formeln börja med den delen med mest paranteser om inte det är så att ett är x och ett annat inte är x. \nSvaret är så kort som det kan vara med alla dessa regler.");
                        //Här förklaras fortsättningen för användaren.
                        if (Console.ReadLine() == svar)
                        {
                            Console.WriteLine("Du har rätt.");
                            svaratRätt = true;
                        }
                        else
                        {
                            Console.WriteLine("Du har fel.");
                        }
                    }
                    else if (gEllerEj != "g")
                    {
                        gEllerEj = gEllerEj.Replace(".", ",");
                        double gEllerEj2;
                        if (!double.TryParse(gEllerEj, out gEllerEj2)) //GEllerEj2 är som vanliga gEllerEj men den har blivit en double.
                            continue;
                        double exemplet = 1.0;
                        if(upgift == "a1")
                        {
                            exemplet = gEllerEj2 * 2;
                        }
                        else if(upgift == "a2")
                        {
                            exemplet = gEllerEj2 * 2 + 1;
                        }
                        else if (upgift == "a3")
                        {
                            exemplet = gEllerEj2 + 2;
                        }
                        else if (upgift == "b1")
                        {
                            exemplet = gEllerEj2 * 4.5;
                        }
                        else if (upgift == "b2")
                        {
                            exemplet = gEllerEj2 * 93.4;
                        }
                        else if (upgift == "b3")
                        {
                            exemplet = gEllerEj2 * 22.8;
                        }
                        else if (upgift == "c1")
                        {
                            exemplet = 3.4;
                        }
                        else if (upgift == "c2")
                        {
                            exemplet = (gEllerEj2 - 1) * gEllerEj2;
                        }
                        else if (upgift == "c3")
                        {
                            exemplet = gEllerEj2 * (-1.63);
                        }
                        else if (upgift == "d1")
                        {
                            exemplet = ((gEllerEj2 - 1) * (gEllerEj2 - 1) * (gEllerEj2 - 1)) + gEllerEj2;
                        }
                        else if (upgift == "d2")
                        {
                            exemplet = (gEllerEj2 * 3.4) + 4.3;
                        }
                        else if (upgift == "d3")
                        {
                            exemplet = (gEllerEj2 - 3.4) * gEllerEj2;
                        }
                        else if (upgift == "e1")
                        {
                            exemplet = ((gEllerEj2 - 3.4) * (gEllerEj2 - 3.4) * (gEllerEj2 - 3.4)) + (gEllerEj2 * 4.3);
                        }
                        else if (upgift == "e2")
                        {
                            exemplet = (((gEllerEj2 * 4.3)) - (gEllerEj2 * 3.4)) - 3.4;
                        }
                        else if (upgift == "e3")
                        {
                            exemplet = (gEllerEj2 * 999998999999999999) / (gEllerEj2 * 2);
                        }
                        Console.WriteLine(exemplet); ///Svaret. Jag knske borde skriva ut det sista snesträcket som slach men man brukar skriva med snesträck och det var bara en gissning på hur man egentligen stavar det.
                    }
                }
            }
        }
    }
}
