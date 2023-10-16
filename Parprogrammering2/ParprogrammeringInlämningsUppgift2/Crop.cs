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
        int quantity { get; set; }

        public Crop(int id, string name, string CropType, int quantity)
            : base(id, name)
        {
            this.CropType = CropType;
            this.quantity = quantity;
        }
    }
}
