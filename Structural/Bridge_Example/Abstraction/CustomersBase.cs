using System;
using Bridge_Example.Implementor;

namespace Bridge_Example.Abstraction
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class CustomersBase
    {
        private DataObject _dataObject;
        protected string Group;

        public CustomersBase(string group)
        {
            Group = group;
        }

        // Property
        public DataObject Data
        {
            set => _dataObject = value;
            get => _dataObject;
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + Group);
            _dataObject.ShowAllRecords();
        }
    }
}