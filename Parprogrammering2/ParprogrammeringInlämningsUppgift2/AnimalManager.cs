using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class AnimalManager
    {
        Animal cow = new Animal(1, "Berit", "cattle", "grass");
        Animal pig = new Animal(2, "Peppa", "pig", "potatis");
        Animal chiken = new Animal(3, "Mette", "chiken", "corn");

        List<Animal> AnimalLists = new List<Animal>();

        public AnimalManager()
        {
            AnimalLists.Add(cow);
            AnimalLists.Add(pig);
            AnimalLists.Add(chiken);
        }

        public void AnimalMenu()
        {
            while (true)
            {
                Console.WriteLine("Välkommen till animal menu");
                Console.WriteLine("Vänligen välj ett val");
                Console.WriteLine("1: Kolla på alla djuren.");
                Console.WriteLine("2: Lägg till ett djur.");
                Console.WriteLine("3: Ta bort ett djur.");

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.Clear();
                            ViewAnimal();
                            break;
                        case 2:
                            Console.Clear();
                            AddAnimal();
                            break;
                        case 3:
                            Console.Clear();
                            RemoveAnimal();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Skriv enbart in ett nummer mellan 1-2");
                            break;
                    }
                }

                catch (Exception e)
                {
                    FarmMenu farmMenu = new FarmMenu();
                    farmMenu.CatchMessage();
                }
            }
        }

        private void ViewAnimal()
        {
            foreach (Animal animal in AnimalLists)
            {
                animal.GetDescription();
            }
        }

        private void AddAnimal()
        {
            Console.WriteLine("Feel free to add a animal!");
            Console.WriteLine("");
            Console.WriteLine("Enter animal ID:");
            int animalId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter animal name:");
            string animalName = Console.ReadLine();
            Console.WriteLine("Enter animal species:");
            string species = Console.ReadLine();
            Console.WriteLine("Enter acceptable crop type:");
            string acceptableCropType = Console.ReadLine();

            Animal newAnimal = new Animal(animalId, animalName, species, acceptableCropType);
            AnimalLists.Add(newAnimal);

            Console.WriteLine("Animal added successfully.");
        }

        private void RemoveAnimal()
        {
            Console.WriteLine("Remove an animal by the animal Id");
            int input = int.Parse(Console.ReadLine());

            foreach (Animal animal in AnimalLists)
            {
                if (animal.Id == input)
                {
                    AnimalLists.Remove(animal);
                    return;
                }
            }
        }

        private void FeedAnimals()
        {
            Console.WriteLine("Välj ett djur att mata.");

            for (int i = 0; 0 < AnimalLists.Count; i++)
            {
                Console.WriteLine(AnimalLists[i].Species);
            }

            string input = Console.ReadLine();

            foreach (Animal animal in AnimalLists)
            {
                if (animal.Species == input)
                {
                    Console.WriteLine("Vilken crop vill du mata djuret?");
                    CropManager crop = new CropManager();
                    for (int i = 0; 0 < crop.CropList.Count; i++)
                    {
                        Console.WriteLine(crop.CropList[i].CropType);
                    }

                    string input2 = Console.ReadLine();
                    animal.Feed(input2);

                }
            }

        }
    }
}
