using System;
using System.Collections.Generic;

namespace Exercise_9
{
    class Car
    {
        private String colour;
        private double engineSize;
        private int fuelEconomy;

        public Car(String colour, double engineSize, int fuelEconomy)
        {
            this.colour = colour;
            this.engineSize = engineSize;
            this.fuelEconomy = fuelEconomy;
        }

        public string Colour { get => colour; set => colour = value; }
        public double EngineSize { get => engineSize; set => engineSize = value; }
        public int FuelEconomy { get => fuelEconomy; set => fuelEconomy = value; }

        public override String ToString()
        {
            String str = "Colour: " + colour + ", Engine Size: " + engineSize + ", Fuel Economy: " + fuelEconomy + "l/ 100km";
            return str;
        }
    }
    class Program
    {
        static bool IsRed(Car car)
        {
            return car.Colour.Equals("Red");
        }
        static void Main(string[] args)
        {
            Car car0 = new Car("Red", 1.4, 6);
            Car car1 = new Car("Blue", 1.6, 5);
            Car car2 = new Car("Red", 2.0, 10);
            Car car3 = new Car("Yellow", 1.2, 5);
            Car car4 = new Car("Blue", 1.8, 7);

            List<Car> cars = new List<Car>{car0, car1, car2, car3, car4};

            var carSearch = cars.FindAll(c => c.EngineSize > 1.4 && c.FuelEconomy < 10);
            foreach(Car car in carSearch)
            {
                System.Console.WriteLine(car.ToString());
            }
        }
    }
}
