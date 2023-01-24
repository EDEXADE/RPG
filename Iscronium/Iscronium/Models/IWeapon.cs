namespace Iscronium.Models;

public class Weapon: Item, Actions.IEquipped
{
    
    protected Weapon(string name, string description) : base(name, description, ItemType.Weapon)
    {
        
    }

    public override void Use()
    {
        
    }
    public void PutOn() => Console.WriteLine($"Equipped");

    public void TakeOff() => Console.WriteLine("Unequipped");
}