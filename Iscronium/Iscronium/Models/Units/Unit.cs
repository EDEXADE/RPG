namespace Iscronium.Models.Units;

public abstract class Unit
{
    // Fields
    public readonly string name;
    public readonly UnitType type;
    
    // Properties
    // ??
    

    // Constructor
    public Unit(string name, UnitType type)
    {
        this.name = name;
        this.type = type;
    }
    
}