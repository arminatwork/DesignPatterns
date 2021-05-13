using AbstractFactory_Example.AbstractFactory;
using AbstractFactory_Example.AbstractProduct;
using AbstractFactory_Example.Product;

namespace AbstractFactory_Example.ConcreteFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}