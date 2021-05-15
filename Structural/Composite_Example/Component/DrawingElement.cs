namespace Composite_Example.Component
{
    /// <summary>
    /// The 'Component' TreeNode
    /// </summary>
    abstract class DrawingElement
    {
        protected string Name;

        // Constructor
        public DrawingElement(string name)
        {
            Name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}