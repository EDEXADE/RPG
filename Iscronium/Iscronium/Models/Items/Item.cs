namespace Iscronium.Models.Items;


// Class for all items
public abstract class Item
{
    public new abstract ItemType GetType();
    protected abstract (string, string) GetInfo();
    public abstract void Use();

    public virtual void Remove()
    {
        
    }
    // todo methods
}