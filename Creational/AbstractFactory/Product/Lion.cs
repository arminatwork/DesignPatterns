using System;
using AbstractFactory_Example.AbstractProduct;

namespace AbstractFactory_Example.Product
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);
        }
    }
}