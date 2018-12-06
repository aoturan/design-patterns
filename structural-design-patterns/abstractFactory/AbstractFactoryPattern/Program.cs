using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory carFactory = FactoryProducer.GetFactory("Car");

            ICar car1 = carFactory.GetCar("Mazda");
            car1.GetCar();

            ICar car2 = carFactory.GetCar("Bmw");
            car2.GetCar();

            ICar car3 = carFactory.GetCar("Ford");
            car1.GetCar();

            AbstractFactory suvFactory = FactoryProducer.GetFactory("Suv");

            ISuv suv1 = suvFactory.GetSuv("Jeep");
            suv1.GetSuv();

            ISuv suv2 = suvFactory.GetSuv("Isuzu");
            suv2.GetSuv();

            ISuv suv3 = suvFactory.GetSuv("Suzuki");
            suv3.GetSuv();


            Console.ReadLine();
        }
    }
}
