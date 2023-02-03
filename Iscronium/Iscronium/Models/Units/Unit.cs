namespace Iscronium.Models.Units;

public abstract class Unit
{
    // Fields
    public readonly string name;
    public readonly UnitType unitType;
    
    // Properties
    // ??
    

    // Constructor
    public Unit(string name, UnitType type)
    {
        this.name = name;
        this.unitType = type;
    }
    
}