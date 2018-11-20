using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.RepairWheels
{
    // описание потраченных материалов
    public class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}