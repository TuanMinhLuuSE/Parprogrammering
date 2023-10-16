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
            Console.WriteLine("Hej välkommen till vår bondgård!");
            Console.WriteLine("Vänligen välj vad du vill göra.");
            Console.WriteLine("1: Hantera djuren.");
            Console.WriteLine("2: Hantera skörden");

            AnimalManager animalManager = new AnimalManager();
            animalManager.ViewAnimal();





        }

    }
}
