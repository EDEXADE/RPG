using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;

namespace Iscronium.Models.Units;

public class Hero: Unit, IInteractive
{
    private Inventory _inventory;
    public Hero(string name, UnitType type)
        : base(name, type)
    {
        _inventory = new Inventory();
    }

    public bool Use(Item item)
    {
        if (_inventory.)
    }
    
    public bool Interact(Object object){
        if (Object is Item)
        {
            
        }
    }
}