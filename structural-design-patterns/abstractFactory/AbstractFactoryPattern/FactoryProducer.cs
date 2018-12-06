namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if(choice.Equals("Car"))
            {
                return new CarFactory();
            }
            else if (choice.Equals("Suv"))
            {
                return new SuvFactory();
            }

            return null;
        }
    }
}
