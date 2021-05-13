using System;
using Prototype_Example.Prototype;

namespace Prototype_Example.ConcretePrototype
{
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return MemberwiseClone() as ColorPrototype;
        }
    }
}