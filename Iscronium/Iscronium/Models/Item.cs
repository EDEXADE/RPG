namespace Iscronium.Models;

public abstract class Item
{
    public ItemType Type { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }

    protected Item(string name, string description, ItemType itemType)
    {
        Type = itemType;
        Name = name;
        Description = description;
    }
    public abstract void Info();
    public abstract void Use();

    public void Remove()
    {
        
    }
    // todo methods
}