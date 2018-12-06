using System;

namespace AbstractFactoryPattern
{
    public class Bmw : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("Car is created: Bmw");
        }
    }
}
