namespace Adapter_Example.Target
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point is "M")
            {
                return compound.ToLower() switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f
                };
            }
            // Boiling Point
            return compound.ToLower() switch
            {
                "water" => 100.0f,
                "benzene" => 80.1f,
                "ethanol" => 78.3f,
                _ => 0f
            };
        }

        public string GetMolecularStructure(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => "H20",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => ""
            };
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}