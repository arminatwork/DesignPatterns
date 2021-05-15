using System;
using Bridge_Example.ConcreteImplementor;
using Bridge_Example.RefinedAbstraction;

namespace Bridge_Example
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Bridge Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create RefinedAbstraction
            Customers customers = new("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
