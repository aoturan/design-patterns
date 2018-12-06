using System;

namespace AbstractFactoryPattern
{
    public class Mazda : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("Car is created: Mazda");
        }
    }
}
