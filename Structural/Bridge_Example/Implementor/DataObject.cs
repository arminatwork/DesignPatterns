namespace Bridge_Example.Implementor
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}