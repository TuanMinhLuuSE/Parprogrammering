using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class CropManager
    {
        Crop Wheat = new Crop(1, "Wheat Field", "wheat", 100);
        Crop Corn = new Crop(2, "Corn Field", "corn", 75);

        public List<Crop> CropList = new List<Crop>();

        public CropManager()
        {
            CropList.Add(Wheat);
            CropList.Add(Corn);
        }

        public void Handelcropmanagement()
        {
            while (true)
            {
                Console.WriteLine("Crop Management menu:");
                Console.WriteLine("1. View Crops");
                Console.WriteLine("2. Add Crops");
                
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            ViewCrops();
                            break;
                        case 2:
                            Console.Clear();
                            AddCrop();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice. Please try again.");
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
        public void ViewCrops()
        {
            Console.WriteLine("Crops on the farm");
            foreach (Crop crop in CropList)
            {
                crop.GetDescription();
            }
        }

        public void AddCrop()
        {
            Console.WriteLine("Feel free to add a crop!");
            Console.WriteLine("");
            Console.WriteLine("Enter Crop ID:");
            int cropId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Crop Name:");
            string cropName = Console.ReadLine();
            Console.WriteLine("Enter Crop Type:");
            string cropType = Console.ReadLine();
            Console.WriteLine("Enter Quantity:");
            int cropQuantity = int.Parse(Console.ReadLine());

            Crop newCrop = new Crop(cropId, cropName, cropType, cropQuantity);
            CropList.Add(newCrop);

            Console.WriteLine("Crop added successfully.");

        }

        
    }
}
