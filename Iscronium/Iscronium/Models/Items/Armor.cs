using Iscronium.Models.Items.Actions;

namespace Iscronium.Models.Items;

// Class of all armors.
// This is item. Can be equipped. (Item, IEquipped)
public class Armor: Item, IEquipped
{
    public Armor(ItemType type, string name, string description, Uri photo) : base(type, name, description, photo)
    {
    }

    // Realise abstraction of Item
    public override void Use()
    {
        if (_isEquipped)
            TakeOff();
        else
            PutOn();
        _isEquipped = !_isEquipped;
    }
    
    // Realise interface IEquipped
    // Yeah, yeah '!true', because 'false' - default value...
    private bool _isEquipped = !true;

    public void PutOn()
    {
        Console.WriteLine($"Equipped {type} {name}");
        
    }

    public void TakeOff()
    {
        Console.WriteLine($"Unequipped {type} {name}");
        
    }
}