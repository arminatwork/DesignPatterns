using AbstractFactory_Example.AbstractFactory;
using AbstractFactory_Example.AbstractProduct;

namespace AbstractFactory_Example.Client
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    class AnimalWorld
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}