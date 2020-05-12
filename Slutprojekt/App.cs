using System;

namespace Slutprojekt // Det här och över skrev inte jag.
{
    public class App
    {
        /// <summary>
        /// Alla dessa är här för att kunna användas i functionerna.
        /// </summary>
        private string svar = "Inte valt ännu."; // Detta värdet är gjort för att bytas senare.
        private Formel a1 = new Formel();
        private Formel a2 = new Formel();
        private Formel a3 = new Formel();
        private Formel b1 = new Formel();
        private Formel b2 = new Formel();
        private Formel b3 = new Formel();
        private Formel c1 = new Formel();
        private Formel c2 = new Formel();
        private Formel c3 = new Formel();
        private Formel d1 = new Formel();
        private Formel d2 = new Formel();
        private Formel d3 = new Formel();
        private Formel e1 = new Formel();
        private Formel e2 = new Formel();
        private Formel e3 = new Formel();

        /// <summary>
        /// Den här funktionen startar spelet.
        /// </summary>
        public void Start() // Denna är public men den gör så att Input som är private körs istället för att göra Input till public så är denna public för någon måste vara public då main inte når App annars.
        {
            SkapaSvar(); // Så här gör den så att SkapaSvar anropas.

            do // do gör så att den körs minst en gång.
            {
                Input(); // Här körs input.

                Console.WriteLine("Vill du spela igen? (ja/nej)");

            } while (Console.ReadLine() == "ja"); // Denna gör så att programmet körs igen men inte direkt från början om användaren vill köra igen så att användaren är kvar och inte behöver trycka på någon knapp mer.

            Console.WriteLine("Hej då!");
            Console.WriteLine("Tryck var du vill för att avsluta."); // Detta står på engelska men rästen är på svenska så därför översätter jag.
        }

        /// <summary>
        /// Funktionen SkapaSvar sparar formler och ger dem namn.
        /// </summary>
        private void SkapaSvar() // Denna gör så att valet av formeln sätter svaret man ska gissa senare.
        {
            a1.Namn = "a1"; // Namn kanske är onödiga men kanske hjälper mig längre fram t.ex om jag vill byta namn.
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
            c1.Formeln = "x*x*2";

            c2.Namn = "c2";
            c2.Formeln = "(x-1)*x";

            c3.Namn = "c3";
            c3.Formeln = "x*-1.63";

            d1.Namn = "d1";
            d1.Formeln = "(x*x)+x+3";

            d2.Namn = "d2";
            d2.Formeln = "(x*3.4)+4.3";

            d3.Namn = "d3";
            d3.Formeln = "(x-3.4)*x";

            e1.Namn = "e1";
            e1.Formeln = "(x*2.4)+(x-3.4)";

            e2.Namn = "e2";
            e2.Formeln = "(x/3)*(x-3)*-x";

            e3.Namn = "e3";
            e3.Formeln = "(x*998999)+(x*2)";
        }

        /// <summary>
        /// Här är där programmet förklarar för användaren vad den ska göra och där den låter den göra det den får genom att ta hänsyn till vad användaren skriver och genom att använda VäljUppgift och BeräknaSvaret.
        /// </summary>
        private void Input()
        {
            bool inteKorrekt = true; // inteKorrekt ser till så att man inte kommer vidare utan att ha gjort rätt. Det är därför den heter inteKorrekt.
            Console.WriteLine("Hej och välkommen till Vad gör programmet med talet?! \nDu får börja att välja en formel och det gör du genom att skriva en bokstav först mellan a och e och ett tal sedan mellan 1 och 3. \nBokstaven är svårighetsgraden där a är lättast och siffran är vilket av talen. Skriv alltid med bara små bokstäver och gör inga mellanrum.\nTryck enter efter varje inmatning och kom ihåg: de högre svårighetsgraderna är riktigt irriterande.");
            // Här förklaras början för användaren.
            string uppgift = "";
            // Här förklaras början för användaren.
            while (inteKorrekt) // While funkar oftare än if så det är för säkerhets skull om jag skulle ändra senare.
            {
                uppgift = Console.ReadLine(); // upgift är valet av uppgift som användaren gör så därför kallar jag den uppgift.

                inteKorrekt = VäljUppgift(uppgift);
            }
            while (true) // While funkar oftare än if så det är för säkerhets skull om jag skulle ändra senare.
            {
                Console.WriteLine("Nu får du börja skriva in tal eller gissningar! \nVill du testa ett tal och se vad det blir skriver du in talet. Vill du gissa så skriver du g har du redan gissat och vill gissa igen skriv in G.");
                // Här förklaras fortsättningen för användaren.
                int antalFel = 0; // antalFel är antalet fel och därför heter den så.
                bool svaratRätt = false; // Denna gör så att användaren kan trycka på en knapp för att stänga av programmet när den gissat rätt.
                while (svaratRätt == false) // Så jag valde While för att den är kortare och mer flexibel om man vill att den ska kunna vara alternativ än do while och funkar lika bra i det här tillfället om det inte är så att man snabbt vill veta om den kör första gången då den är marginellt sämre.
                {
                    string gEllerEj = Console.ReadLine(); // gEllerEj heter så för att den kommer kollas om den är g.
                    if (gEllerEj == "g" || gEllerEj == "G")
                    {
                        if (gEllerEj == "g")
                        {
                            Console.WriteLine("Du har valt att gissa skriv in formeln du gissar! \nTalen du skrivit in skriver du som x. Skriv paranteser runt varje uträkning som prioriteras före någon annan uträkning så att den har fler paranteser. \nBörja med x före vanliga tal men prioritera x som ändras före x som inte gör det t.ex x/2 före x. Använd bara de fyra räknesätten och de måste vara utskrivna helt. \nOm det finns olika sätt att skriva formeln börja med den delen med mest paranteser om inte det är så att ett är x och ett annat inte är x. \nSvaret är så kort som det kan vara med alla dessa regler.");
                            // Här förklaras fortsättningen för användaren.
                        }
                        var gissning = Console.ReadLine().Replace(",", ".");
                        if (gissning == svar)
                        {
                            Console.WriteLine("Du har rätt.");
                            Console.WriteLine("Du har gjort " + antalFel + " fel."); // Här ser man hur många felgissningar man gjort.
                            return; // Hoppa ut ur funktionen
                        }
                        else
                        {
                            Console.WriteLine("Du har fel men det hindrar dig inte från att fortsätta.");
                            antalFel++;
                        }
                    }
                    else if (gEllerEj != "g" && gEllerEj != "G")
                    {
                        double x;

                        gEllerEj = gEllerEj.Replace(".", ","); // Gör så att man inte får fel för att man använder fel tecken.
                        if (double.TryParse(gEllerEj, out x)) // x är som vanliga gEllerEj men den har blivit en double.
                        {
                            double svar = BeräknaSvaret(uppgift, x);

                            Console.WriteLine(svar);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Detta är en funktion för att välja en uppgift.
        /// </summary>
        /// <param name="uppgift">Den valda uppgiften.</param>
        /// <returns>true om man inte valt korrekt</returns>
        private bool VäljUppgift(string uppgift)
        {
            switch (uppgift) // Elias sa att det var så man gjorde det och det ser mindre ut så därför gjorde jag det.
            {
                case "a1": // Så det är lite som en if sats case är som if eller else if. Altså kollar den här om användaren skrivit a1.
                    svar = a1.Formeln;
                    Console.WriteLine("Du har valt:" + a1.Namn);
                    break;
                case "a2":
                    svar = a2.Formeln;
                    Console.WriteLine("Du har valt:" + a2.Namn);
                    break;
                case "a3":
                    svar = a3.Formeln;
                    Console.WriteLine("Du har valt:" + a3.Namn);
                    break;
                case "b1":
                    svar = b1.Formeln;
                    Console.WriteLine("Du har valt:" + b1.Namn);
                    break;
                case "b2":
                    svar = b2.Formeln;
                    Console.WriteLine("Du har valt:" + b2.Namn);
                    break;
                case "b3":
                    svar = b3.Formeln;
                    Console.WriteLine("Du har valt:" + b3.Namn);
                    break;
                case "c1":
                    svar = c1.Formeln;
                    Console.WriteLine("Du har valt:" + c1.Namn);
                    break;
                case "c2":
                    svar = c2.Formeln;
                    Console.WriteLine("Du har valt:" + c2.Namn);
                    break;
                case "c3":
                    svar = c3.Formeln;
                    Console.WriteLine("Du har valt:" + c3.Namn);
                    break;
                case "d1":
                    svar = d1.Formeln;
                    Console.WriteLine("Du har valt:" + d1.Namn);
                    break;
                case "d2":
                    svar = d2.Formeln;
                    Console.WriteLine("Du har valt:" + d2.Namn);
                    break;
                case "d3":
                    svar = d3.Formeln;
                    Console.WriteLine("Du har valt:" + d3.Namn);
                    break;
                case "e1":
                    svar = e1.Formeln;
                    Console.WriteLine("Du har valt:" + e1.Namn);
                    break;
                case "e2":
                    svar = e2.Formeln;
                    Console.WriteLine("Du har valt:" + e2.Namn);
                    break;
                case "e3":
                    svar = e3.Formeln;
                    Console.WriteLine("Du har valt:" + e3.Namn);
                    break;
                default: // Om inte man skrivit något över händer detta.
                    return true;
            }
            return false;

        }

        /// <summary>
        /// Här beräknas svaret på vad programmet gör med just det talet användaren skrivit in.
        /// </summary>
        /// <param name="uppgift">Vilken uppgift programmet ska beräkna svaret med.</param>
        /// <param name="x">Det är talet användaren skrivit in.</param>
        /// <returns>Det beräknade funktionsvärdet</returns>
        private double BeräknaSvaret(string uppgift, double x)
        {
            double svar = 1.0; // Detta värdet är gjort för att bytas senare.
            if (uppgift == "a1")
            {
                svar = x * 2; // Här är var datorn räknar ut vad talet blir om man skrivit a1.
            }
            else if (uppgift == "a2")
            {
                svar = x * 2 + 1;
            }
            else if (uppgift == "a3")
            {
                svar = x + 2;
            }
            else if (uppgift == "b1")
            {
                svar = x * 4.5;
            }
            else if (uppgift == "b2")
            {
                svar = x * 93.4;
            }
            else if (uppgift == "b3")
            {
                svar = x * 22.8;
            }
            else if (uppgift == "c1")
            {
                svar = (x * x) * 2;
            }
            else if (uppgift == "c2")
            {
                svar = (x - 1) * x;
            }
            else if (uppgift == "c3")
            {
                svar = x * (-1.63);
            }
            else if (uppgift == "d1")
            {
                svar = ((x * x) + x) + 3;
            }
            else if (uppgift == "d2")
            {
                svar = (x * 3.4) + 4.3;
            }
            else if (uppgift == "d3")
            {
                svar = (x - 3.4) * x;
            }
            else if (uppgift == "e1")
            {
                svar = ((x * 2.4)) + (x - 3.4);
            }
            else if (uppgift == "e2")
            {
                svar = (((x / 3)) * (x - 3)) * (-x);
            }
            else if (uppgift == "e3")
            {
                svar = ((x * 998999)) + (x * 2); // Funkar fortfarnade inte.
            }

            return svar;
        }
    }
}
