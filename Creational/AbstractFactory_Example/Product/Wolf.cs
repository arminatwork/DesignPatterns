using System;
using AbstractFactory_Example.AbstractProduct;

namespace AbstractFactory_Example.Product
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);
        }
    }
}