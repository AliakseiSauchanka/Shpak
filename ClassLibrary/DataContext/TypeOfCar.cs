using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.DataContext
{
    // описание типа автомобиля
    public class TypeOfCar
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Wheels { get; set; }
    }
}