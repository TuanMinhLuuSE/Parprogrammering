using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class CropManager
    {
      Crop wheat = new Crop(1, "Wheat Field", "wheat", 100);
      Crop corn = new Crop(2, "Corn Field", "corn", 75);

    List<Crop> CropList = new List<Crop>();

    Public CropManager ()
    {
      CropList.Add(Wheat);
      CropList.Add(Corn);
    }
    Public void Viewcrops()
     {
        Console.WriteLine("Crops on the farm") //kan ändra text bara ett exempel
        Foreach (Crop crop in Croplist) 
        {
            crop.GetDiscribtion();
        }
     }
        
     
    }
}
