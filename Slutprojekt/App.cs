using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt //Det här och över skrev inte jag.
{
    class App
    {
        private string svar = "Inte valt ännu."; //Detta värdet är gjort för att bytas senare.
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

        public void Start() //Denna är public men den gör så att Input som är private körs.
        {
            SkapaSvar(); //Så här gör den så att SkapaSvar anropas.

            do
            {
                Input();

                Console.WriteLine("Vill du spela igen? (ja/nej)");

            } while (Console.ReadLine() == "ja");

            Console.WriteLine("Hej då!");
        }

        private void SkapaSvar() //Denna gör så att valet av formeln sätter svaret man ska gissa senare.
        {
            a1.Namn = "a1"; //Namn kanske är onödiga men kanske hjälper mig längre fram t.ex om jag vill byta namn.
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
            c1.Formeln = "(x*x)*2";

            c2.Namn = "c2";
            c2.Formeln = "(x-1)*x";

            c3.Namn = "c3";
            c3.Formeln = "x*(-1.63)";

            d1.Namn = "d1";
            d1.Formeln = "((x*x)+x)+3";

            d2.Namn = "d2";
            d2.Formeln = "(x*3.4)+4.3";

            d3.Namn = "d3";
            d3.Formeln = "(x-3.4)*x";

            e1.Namn = "e1";
            e1.Formeln = "((x*0.4))+(x-3.4)";

            e2.Namn = "e2";
            e2.Formeln = "(((x/3))*(x/2))*(x-3.4)";

            e3.Namn = "e3";
            e3.Formeln = "((x*999998999999999999))/(x*2)";
        }

        private void Input()
        {
            bool inteKorrekt = true; //inteKorrekt ser till så att man inte kommer vidare utan att ha gjort rätt.
            Console.WriteLine("Hej och välkommen till Vad gör programmet med talet?! \nDu får börja att välja en formel och det gör du genom att skriva en bokstav först mellan a och e och ett tal sedan mellan 1 och 3. \nBokstaven är svårighetsgraden där a är lättast och siffran är vilket av talen. Skriv alltid med bara små bokstäver och gör inga mellanrum.\nTryck enter efter varje inmatning och kom ihåg: de högre svårighetsgraderna är riktigt irriterande.");
            //Här förklaras början för användaren.
            while (inteKorrekt) //While funkar oftare än if så det är för säkerhets skull om jag skulle ändra senare.
            {
                inteKorrekt = false;
                string upgift = Console.ReadLine(); //upgift är valet av uppgift som användaren gör så därför kallar jag den uppgift.

                switch (upgift) //Elias sa att det var så man gjorde det och det ser mindre ut så därför gjorde jag det.
                {
                    case "a1": //Så det är lite som en if sats case är som if eller else if. Altså kollar den här om användaren skrivit a1.
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
                    default:
                        inteKorrekt = true; 
                        break;
                }
                if(inteKorrekt == false)
                {
                    Console.WriteLine("Nu får du börja skriva in tal eller gissningar! \nVill du testa ett tal och se vad det blir skriver du in talet. Vill du gissa så skriver du g har du redan gissat och vill gissa igen skriv in G.");
                    //Här förklaras fortsättningen för användaren.
                    int antalFel = 0;
                    bool svaratRätt = false; //Denna gör så att användaren kan trycka på en knapp för att stänga av programmet när den gissat rätt.
                    while (svaratRätt == false)
                    {
                        string gEllerEj = Console.ReadLine(); //gEllerEj heter så för att den kommer kollas om den är g.
                        if (gEllerEj == "g" || gEllerEj == "G")
                        {
                            if (gEllerEj == "g")
                            {
                                Console.WriteLine("Du har valt att gissa skriv in formeln du gissar! \nTalen du skrivit in skriver du som x. Skriv paranteser runt varje uträkning som prioriteras före någon annan uträkning så att den har fler paranteser. \nBörja med x före vanliga tal men prioritera x som ändras före x som inte gör det t.ex x/2 före x. Använd bara de fyra räknesätten och de måste vara utskrivna helt. \nOm det finns olika sätt att skriva formeln börja med den delen med mest paranteser om inte det är så att ett är x och ett annat inte är x. \nSvaret är så kort som det kan vara med alla dessa regler.");
                                //Här förklaras fortsättningen för användaren.
                            }
                            var gissning = Console.ReadLine().Replace(",", ".");
                            if (gissning == svar)
                            {
                                Console.WriteLine("Du har rätt.");
                                Console.WriteLine("Du har gjort " + antalFel + " fel."); //Här ser man hur många felgissningar man gjort.
                                svaratRätt = true;
                            }
                            else
                            {
                                Console.WriteLine("Du har fel men det hindrar dig inte från att fortsätta.");
                                antalFel++;
                            }
                        }
                        else if (gEllerEj != "g" && gEllerEj != "G")
                        {
                            gEllerEj = gEllerEj.Replace(".", ","); //Gör så att man inte får fel för att man använder fel tecken.
                            double gEllerEj2;
                            if (!double.TryParse(gEllerEj, out gEllerEj2)) //GEllerEj2 är som vanliga gEllerEj men den har blivit en double.
                                continue;
                            double exemplet = 1.0; //Detta värdet är gjort för att bytas senare.
                            if (upgift == "a1")
                            {
                                exemplet = gEllerEj2 * 2; //Här är var datorn räknar ut vad talet blir om man skrivit a1.
                            }
                            else if (upgift == "a2")
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
                                exemplet = (gEllerEj2 * gEllerEj2) * 2;
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
                                exemplet = ((gEllerEj2 * 2.4)) + (gEllerEj2 - 3.4);
                            }
                            else if (upgift == "e2")
                            {
                                exemplet = (((gEllerEj2 / 3)) * (gEllerEj2 / 2)) * (gEllerEj2 - 3.4);
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
}
