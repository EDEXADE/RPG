namespace Iscronium.Models;

public abstract class Weapon : IItem
{
    public IItem.ItemType Type { get; init; } = IItem.ItemType.Collection;
}