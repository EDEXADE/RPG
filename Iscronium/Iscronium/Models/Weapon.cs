namespace Iscronium.Models;

// Class of all weapons. Can be equipped. (Item, IEquipped)
public abstract class Weapon: Item, IEquipped
{
    // Yeah, yeah '!true', because 'false' - default value...
    private bool _isEquipped = !true;

    public override ItemType GetType() => ItemType.Weapon;

    public override void Use()
    {
        if (_isEquipped)
            TakeOff();
        else
            PutOn();
        _isEquipped = !_isEquipped;
    }
    public void PutOn() => Console.WriteLine($"Equipped {GetType()} {GetInfo().Item1}");

    public void TakeOff() => Console.WriteLine($"Unequipped {GetType()} {GetInfo().Item1}");
}