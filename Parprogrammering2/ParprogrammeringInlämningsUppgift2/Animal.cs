using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class Animal : Entity
    {
        public string Species { get; set; }
        string AcceptableCropType { get; set; }

        public Animal(int id, string name, string Species, string AcceptableCropType)
            : base(id, name)
        {
            this.Species = Species;
            this.AcceptableCropType = AcceptableCropType;

        }

        public override void GetDescription()
        {
            string sentence = $"{Id} {Name} {Species} {AcceptableCropType}\n";
            Console.Write(sentence);
        }

        public void Feed(string input2)
        {
            CropManager crop = new CropManager();
            foreach (Crop crops in crop.CropList)
            {
                if (input2 == crops.CropType && input2 == AcceptableCropType)
                {
                    crops.TakeCrop(input2);
                }
            }
        }
    }
}
