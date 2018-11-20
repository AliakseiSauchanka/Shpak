using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.RepairWheels
{
    public class PriceMaterials
    {
        public int PriceMaterialsId { get; set; }
        public DateTime CreateDate { get; set; }

        // Tube patches
        public decimal N0 { get; set; }
        public decimal N1 { get; set; }
        public decimal N2 { get; set; }
        public decimal N3 { get; set; }
        public decimal N4 { get; set; }
        public decimal N5 { get; set; }
        public decimal N6 { get; set; }

        // Tire patches
        public decimal Up3 { get; set; }
        public decimal Up4 { get; set; }
        public decimal Up6 { get; set; }
        public decimal TL110 { get; set; }
        public decimal TL115 { get; set; }
        public decimal TL116 { get; set; }
        public decimal TL120 { get; set; }

        // Valves
        public decimal TR412 { get; set; }
        public decimal TR413 { get; set; }
        public decimal TR414 { get; set; }
        public decimal TR418 { get; set; }
        public decimal Chrome { get; set; }
        public decimal Metal { get; set; }
        public decimal Ext140 { get; set; }
        public decimal Ext136 { get; set; }
        public decimal Bracket { get; set; }
    }
}
