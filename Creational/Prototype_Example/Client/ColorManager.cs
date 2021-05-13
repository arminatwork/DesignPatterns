using System.Collections.Generic;
using Prototype_Example.Prototype;

namespace Prototype_Example.Client
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors = new();

        // Indexer
        public ColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}