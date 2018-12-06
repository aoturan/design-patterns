using System;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract ICar GetCar(String carName);
        public abstract ISuv GetSuv(String suvName);

    }
}
