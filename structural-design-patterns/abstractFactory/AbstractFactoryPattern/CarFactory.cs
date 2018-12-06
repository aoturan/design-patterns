namespace AbstractFactoryPattern
{
    public class CarFactory : AbstractFactory
    {
        public override ICar GetCar(string carName)
        {
            if(string.IsNullOrWhiteSpace(carName))
            {
                return null;
            }

            if (carName.Equals("Mazda"))
            {
                return new Mazda();
            }
            else if (carName.Equals("Ford"))
            {
                return new Ford();
            }
            else if (carName.Equals("Bmw"))
            {
                return new Bmw();
            }
            else
                return null;
        }

        public override ISuv GetSuv(string suvName)
        {
            return null;
        }
    }
}
