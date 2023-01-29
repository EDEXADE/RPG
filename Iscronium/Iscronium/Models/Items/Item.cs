namespace Iscronium.Models.Items;

// Class for all items
public abstract class Item
{
    public string name;
    // Properties
    private ItemType Type { get; }
    private string Name { get; }
    private string Description { get; }
    private Uri Photo { get; }
    
    // Constructor
    public Item(ItemType type,
        string name, string description, Uri photo)
    {
        Type = type;
        Name = this.name = name;
        Description = description;
        Photo = photo;
    }

    // Abstract methods, implemented by inheritor
    public abstract void Use();

    // Virtual methods, what can override if necessary
    public virtual void Remove()
    {
        
    }
    
    // todo methods
}