namespace Data.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public int TypeOfCarId { get; set; }
        public virtual TypeOfCar TypeOfCar { get; set; }
    }
}