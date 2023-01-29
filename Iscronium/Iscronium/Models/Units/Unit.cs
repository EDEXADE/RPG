    using System.Reflection.Metadata;
    using Iscronium.Models.Items;

namespace Iscronium.Models.Units;

public abstract class Unit
{
    // Properties
    public string Name { get; }
    public UnitType Type { get; }

    // Constructor
    public Unit(string name, UnitType type)
    {
        Name = name;
        Type = type;
    }
    
}