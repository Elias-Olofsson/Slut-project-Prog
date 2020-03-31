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
            Console.WriteLine("1"); //Här förklaras början för användaren.
            bool inCorrect = true;
            while (inCorrect)
            {
                inCorrect = false;
                string upgift = Console.ReadLine();
                switch (upgift)
                {
                    case "a1":
                        svar = "*2";
                        break;
                    case "a2":
                        svar = "";
                        break;
                    case "a3":
                        svar = "";
                        break;
                    case "b1":
                        svar = "";
                        break;
                    case "b2":
                        svar = "";
                        break;
                    case "b3":
                        svar = "";
                        break;
                    case "c1":
                        svar = "";
                        break;
                    case "c2":
                        svar = "";
                        break;
                    case "c3":
                        svar = "";
                        break;
                    case "d1":
                        svar = "";
                        break;
                    case "d2":
                        svar = "";
                        break;
                    case "d3":
                        svar = "";
                        break;
                    case "e1":
                        svar = "";
                        break;
                    case "e2":
                        svar = "";
                        break;
                    case "e3":
                        svar = "";
                        break;
                    default:
                        inCorrect = true;
                        break;
                }
                Console.WriteLine("2"); //Här förklaras fortsättningen för användaren.
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
                    if (gEllerEj != "g")
                    {
                        double gEllerEj2 = double.Parse(gEllerEj); //GEllerEj2 är som vanliga gEllerEj men den har blivit en double.
                        double exemplet = 1.0;
                        if(upgift == "a1")
                        {
                            exemplet = gEllerEj2 * 2;
                        }
                        else if(upgift == "a2")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "a3")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "b1")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "b2")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "b3")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "c1")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "c2")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "c3")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "d1")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "d2")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "d3")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "e1")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "e2")
                        {
                            exemplet = gEllerEj2;
                        }
                        else if (upgift == "e3")
                        {
                            exemplet = gEllerEj2;
                        }
                        Console.WriteLine(exemplet);
                    }
                }
            }
        }
    }
}
