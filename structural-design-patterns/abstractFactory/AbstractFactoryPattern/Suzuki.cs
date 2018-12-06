using System;

namespace AbstractFactoryPattern
{
    public class Suzuki : ISuv
    {
        public void GetSuv()
        {
            Console.WriteLine("Suv is created: Suzuki");
        }
    }
}
