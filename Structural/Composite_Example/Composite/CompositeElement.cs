using System;
using System.Collections.Generic;
using Composite_Example.Component;

namespace Composite_Example.Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> _elements = new();

        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            _elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            _elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) +
                              "+ " + Name);

            // Display each child element on this node
            foreach (DrawingElement d in _elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}