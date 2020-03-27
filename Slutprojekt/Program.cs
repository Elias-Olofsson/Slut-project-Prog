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
                        svar =
                        break;
                    case "a2":
                        svar =
                        break;
                    case "a3":
                        svar =
                        break;
                    case "b1":
                        svar =
                        break;
                    case "b2":
                        svar =
                        break;
                    case "b3":
                        svar =
                        break;
                    case "c1":
                        svar =
                        break;
                    case "c2":
                        svar =
                        break;
                    case "c3":
                        svar =
                        break;
                    case "d1":
                        svar =
                        break;
                    case "d2":
                        svar =
                        break;
                    case "d3":
                        svar =
                        break;
                    case "e1":
                        svar =
                        break;
                    case "e2":
                        svar =
                        break;
                    case "e3":
                        svar =
                        break;
                    default:
                        inCorrect = true;
                        break;
                }
                Console.WriteLine("2"); //Här förklaras fortsättningen för användaren.

                string vad = Console.ReadLine();
                while(vad == "g")
                {
                    if(Console.ReadLine() == svar)
                    {
                        Console.WriteLine("Du har rätt.");
                    }
                    else
                    {
                        Console.WriteLine("Du har fel.");

                    }
                }

                
            }
            
        }
    }
}
