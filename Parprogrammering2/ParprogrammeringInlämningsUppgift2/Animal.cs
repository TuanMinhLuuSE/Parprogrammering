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
    }
}
