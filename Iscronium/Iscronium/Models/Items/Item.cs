namespace Iscronium.Models.Items;

// Class for all items
public abstract class Item
{
    // Fields
    public readonly string name;
    public readonly string description;
    public readonly ItemType type;
    
    // Properties ??
    private Uri Photo { get; }
    
    // Constructor
    public Item(ItemType type,
        string name, string description, Uri photo)
    {
        this.type = type;
        this.name = name;
        this.description = description;
        Photo = photo;
    }

    // Abstract methods, implemented by inheritor
    public abstract void Use();

    // Virtual methods, what can override if necessary
    public virtual void GetInfo()
    {
        Console.WriteLine("About");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine();
    }
    
    public virtual void Remove()
    {
        
    }
    
    // todo methods
}