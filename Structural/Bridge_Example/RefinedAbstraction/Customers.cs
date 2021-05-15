using System;
using Bridge_Example.Abstraction;

namespace Bridge_Example.RefinedAbstraction
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group)
            : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}