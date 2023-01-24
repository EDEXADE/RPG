namespace Iscronium.Models;

public interface IItem
{
    public enum ItemType {
        Weapon,
        Equipment,
        Food,
        Potion,
        Collection
    }
    
    public ItemType Type { get; init; }
    
}