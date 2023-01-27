using Iscronium.Models.Items;

namespace Iscronium.Models.Units;

public class Unit
{
    
    public string Name { get; }
    public UnitType Type { get; }
    public Unit(string name, UnitType type)
    {
        Name = name;
        Type = type;
    }
}