using ClassLibrary.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.RepairWheels
{
    // описание выполненной работы
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int? TypeOfCarId { get; set; }
        public TypeOfCar TypeOfCar { get; set; }

        public override string ToString()
        {
            return (Name + Price);
        }
    }
}
