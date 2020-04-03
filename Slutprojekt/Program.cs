using System;

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
        private string svar;
        public void Start()
        {
            Input();
        }

        private void Input()
        {
            Console.WriteLine("Hej och välkommen till vad gör programmet med talet! \nDu får börja att välja tal och det gör du genom att skriva en bokstav mellan a och e och ett tal mellan 1 och 3. \nBokstaven är svårighetsgraden där a är lättast och siffran är vilket av talen. Skriv alltid med bara små bokstäver och gör inga mellanrum."); 
            //Här förklaras början för användaren.
            bool inCorrect = true;
            while (inCorrect)
            {
                inCorrect = false;
                string upgift = Console.ReadLine();
                switch (upgift)
                {
                    case "a1":
                        svar = "x*2";
                        break;
                    case "a2":
                        svar = "(x*2)+1";
                        break;
                    case "a3":
                        svar = "x+2";
                        break;
                    case "b1":
                        svar = "x*4.5";
                        break;
                    case "b2":
                        svar = "x*93.4";
                        break;
                    case "b3":
                        svar = "x*22.9";
                        break;
                    case "c1":
                        svar = "3.4";
                        break;
                    case "c2":
                        svar = "(x-1)*x";
                        break;
                    case "c3":
                        svar = "x*(-1.63)";
                        break;
                    case "d1":
                        svar = "((x-1)*(x-1)*(x-1))+x";
                        break;
                    case "d2":
                        svar = "(x*3.4)+4.3";
                        break;
                    case "d3":
                        svar = "(x-3.4)*x";
                        break;
                    case "e1":
                        svar = "((x-3.4)*(x-3.4)*(x-3.4))+(x*4.3)";
                        break;
                    case "e2":
                        svar = "(((x*4.3))-(x*3.4))-3.4";
                        break;
                    case "e3":
                        svar = "(x*999998999999999999)/(x*2)";
                        break;
                    default:
                        inCorrect = true;
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
                        Console.WriteLine("Du har valt att gissa skriv in formeln du gissar! \nOm formeln har en variabel så skriv den som x. Skriv paranteser runt varje uträkning som prioriteras före någon annan uträkning. \nBörja med x om det är ett x. Använd bara de fyra räknesätten och de måste vara utskrivna helt. \nOm det finns olika sätt att skriva formeln börja med den delen med mest paranteser om inte ett är x och ett annat inte. \nSvaret är så kort som det kan vara med alla dessa regler.");
                        //Här förklaras fortsättningen för användaren.
                        double gEllerEj2 = double.Parse(gEllerEj); //GEllerEj2 är som vanliga gEllerEj men den har blivit en double.
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
                            exemplet = gEllerEj2 * 22;
                        }
                        else if (upgift == "c1")
                        {
                            exemplet = 3.4;
                        }
                        else if (upgift == "c2")
                        {
                            exemplet = gEllerEj2 -1 * gEllerEj2;
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
                        Console.WriteLine(exemplet);
                    }
                }
            }
        }
    }
}
