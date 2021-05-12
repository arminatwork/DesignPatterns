using AbstractFactory_Example.AbstractFactory;
using AbstractFactory_Example.AbstractProduct;
using AbstractFactory_Example.Product;

namespace AbstractFactory_Example.ConcreteFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}