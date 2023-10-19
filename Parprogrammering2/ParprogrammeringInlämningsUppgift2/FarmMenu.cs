using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class FarmMenu
    {
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Hej välkommen till vår bondgård!");
                Console.WriteLine("Vänligen välj vad du vill göra.");
                Console.WriteLine("1: Hantera djuren.");
                Console.WriteLine("2: Hantera skörden");
                Console.WriteLine("3: Avbryt programmet.");
                
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    switch(input)
                    {
                        case 1:
                            Console.Clear();
                            AnimalManager animalManager = new AnimalManager();
                            animalManager.AnimalMenu();
                            break;
                        case 2:
                            Console.Clear();
                            CropManager cropManager = new CropManager();
                            cropManager.Handelcropmanagement();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Du avbryter nu programmet.");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Skriv enbart in ett nummer mellan 1-3 tack.");
                            break;
                    }
                }

                catch
                {
                    CatchMessage();
                }
            }
        }

        public void CatchMessage()
        {
            Console.WriteLine("Du skrev inte in ett nummer");
            Console.WriteLine("Var god försök igen");
            Console.WriteLine("Tryck på en valfri tanget när du är redo att gå vidare.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
