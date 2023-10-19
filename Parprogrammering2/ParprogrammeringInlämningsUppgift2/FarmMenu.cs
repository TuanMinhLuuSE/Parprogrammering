using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class FarmMenu
    {
        private AnimalManager animalManger;
        private Cropmanager cropManager;

       public FarmMneu()
        {
            animalManager = new AnimalManager();
            cropManager = new CropManager();
        }
        public void Handelcropmanagement()
        {
            Console.WriteLine(" Crop Management menu:");
            Console.WriteLine("1. View Crops");
            Console.WriteLine("2. Manage Crops");

            int choice;
            if (int.TryParce(Console.ReadLine(), out choice))
            {
                swich (choice)
                {
                    case 1: 
                      cropManager.ViewCrops();
                        break:
                    case 2:
                    Console.WriteLine("Enter Crop ID:");
                    int cropId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Crop Name:");
                    string cropName = Console.ReadLine();
                    Console.WriteLine("Enter Crop Type:");
                    string cropType = Console.ReadLine();
                    Console.WriteLine("Enter Quantity:");
                    int cropQuantity = int.Parse(Console.ReadLine());

                Crop newCrop = new Crop(cropId, cropName, cropType, cropQuantity);
                cropManager.AddCrop(newCrop);

                Console.WriteLine("Crop added successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }  

        public void MainMenu()
        {
            Console.WriteLine("Hej välkommen till vår bondgård!");

            while (true)
            {
                Console.WriteLine("Vänligen välj vad du vill göra.");
                Console.WriteLine("1: Hantera djuren.");
                Console.WriteLine("2: Hantera skörden");
            }

            int choice
              if (int.TryParce(Console.ReadLine(), out choice))
            {
                swich (choice)
                {
                    case 1: 
                      HandelAnimalMangement();
                    break:
                     case 2. HandelCropMangement();
                    break:
                         

            AnimalManager animalManager = new AnimalManager();
          





        }

    }
}
