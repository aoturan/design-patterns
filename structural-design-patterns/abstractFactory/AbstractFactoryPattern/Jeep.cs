using System;

namespace AbstractFactoryPattern
{
    public class Jeep : ISuv
    {
        public void GetSuv()
        {
            Console.WriteLine("Suv is created: Jeep");
        }
    }
}
