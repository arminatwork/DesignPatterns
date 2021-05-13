using System.Collections.Generic;
using FactoryMethod_Example.Product;

namespace FactoryMethod_Example.Creator
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages => _pages;

        // Factory Method
        public abstract void CreatePages();
    }
}