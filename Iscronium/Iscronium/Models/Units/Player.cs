using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;

namespace Iscronium.Models.Units;

public class Player: Unit, IInteractive
{
    private readonly Inventory _inventory;
    public Player(string name)
        : base(name, UnitType.Player)
    {
        _inventory = new Inventory();
    }
    
    public Inventory GetInventory()
    {
        return _inventory;
    }

    public void Add(Item item)
    {
        _inventory.Add(item);
    }
    
    public void Use(Item item)
    {
        _inventory.Use(item);
    }

    public void Interact(Player player)
    {
        Console.WriteLine($"{Name} -> {player.Name}");
    }
    
    public void Interact(object obj){
        if (obj is IInteractive interactive)
            interactive.Interact(this);
    }
}