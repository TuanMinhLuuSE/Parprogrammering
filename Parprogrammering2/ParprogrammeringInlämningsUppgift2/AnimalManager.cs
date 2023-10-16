using System;
using System.Collections.Generic;
using System.Linq;
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

        public void ViewAnimal()
        {
            foreach (Animal animal in AnimalLists)
            { 
                animal.GetDescription();

            }
 
            
         
        }
    }
}
