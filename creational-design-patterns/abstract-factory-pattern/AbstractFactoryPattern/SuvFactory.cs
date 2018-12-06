namespace AbstractFactoryPattern
{
    public class SuvFactory : AbstractFactory
    {
        public override ICar GetCar(string carName)
        {
            return null;
        }

        public override ISuv GetSuv(string suvName)
        {
            if(string.IsNullOrWhiteSpace(suvName))
            {
                return null;
            }

            if (suvName.Equals("Jeep"))
            {
                return new Jeep();
            }
            else if (suvName.Equals("Isuzu"))
            {
                return new Isuzu();
            }
            else if (suvName.Equals("Suzuki"))
            {
                return new Suzuki();
            }
            else
                return null;
        }
    }
}
