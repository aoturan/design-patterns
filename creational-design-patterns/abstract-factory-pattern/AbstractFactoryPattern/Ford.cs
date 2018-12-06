using System;

namespace AbstractFactoryPattern
{
    public class Ford : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("Car is created: Ford");
        }
    }
}
