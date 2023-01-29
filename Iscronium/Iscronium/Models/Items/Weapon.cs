using Iscronium.Models.Items.Actions;

namespace Iscronium.Models.Items;

// Class of all weapons.
// This is item. Can be equipped. (Item, IEquipped)
public class Weapon: Item, IEquipped
{
    // Constructor
    public Weapon(string name, string description, Uri photo)
        : base(ItemType.Weapon, name, description, photo)
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
    
    public void PutOn() => Console.WriteLine($"Equipped {this.ToString()} {name}");
    public void TakeOff() => Console.WriteLine($"Unequipped {this.ToString()} {name}");
}