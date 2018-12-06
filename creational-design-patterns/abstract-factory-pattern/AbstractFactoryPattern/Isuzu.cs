using System;

namespace AbstractFactoryPattern
{
    public class Isuzu : ISuv
    {
        public void GetSuv()
        {
            Console.WriteLine("Suv is created: Isuzu");
        }
    }
}
