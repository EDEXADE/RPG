using Iscronium.Models.Items.Actions;

namespace Iscronium.Models.Items;

// Class of all potions.
// This is item. Can be consume. (Item, IConsumable)
public class Potion: Item, IConsumable
{
    // Constructor
    public Potion(string name, string description, Uri photo)
        : base(ItemType.Potion, name, description, photo)
    {
    }
    
    // Realise abstraction of Item
    public override void Use()
    {
        // todo
    }
    
    // Realise interface IConsumable
    
     // todo
}