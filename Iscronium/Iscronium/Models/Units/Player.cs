using Iscronium.Models.Statss;
using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;

namespace Iscronium.Models.Units;

public class Player: Unit, IInteractive
{
    private readonly Level _level;
    private readonly Stats _stats;
    private readonly Inventory _inventory;
    public Player(string name)
        : base(name, UnitType.Player)
    {
        _level = new Level();
        _stats = new Stats();
        _inventory = new Inventory();
    }

    public Level GetLevel() => _level;
    public Stats GetStats() => _stats;
    public Inventory GetInventory() => _inventory;

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
        Console.WriteLine("New interaction:");
        Console.WriteLine($"{name} -> {player.name}");
        Console.WriteLine();
    }
    
    public void Interact(object obj){
        if (obj is IInteractive interactive)
            interactive.Interact(this);
    }
}