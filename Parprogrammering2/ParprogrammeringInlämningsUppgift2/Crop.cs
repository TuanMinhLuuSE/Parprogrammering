using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringInlämningsUppgift2
{
    internal class Crop : Entity
    {
        public string CropType { get; set; }
        int Quantity { get; set; }

        public Crop(int id, string name, string cropType, int quantity)
            : base(id, name)
        {
            this.CropType = cropType;
            this.Quantity = quantity;
        }

        public override void GetDescription()
        {
        
        }

        public void TakeCrop(string input2)
        {
            
        }
    }

}
