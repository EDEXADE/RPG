using Iscronium.Models.Statss;
using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;

namespace Iscronium.Models.Units;

public class Player: Unit, IInteractive
{
    // Fields
    private readonly Level _level;
    private readonly Stats _stats;
    private readonly Inventory _inventory;

    // Constructor
    public Player(string name)
        : base(name, UnitType.Player)
    {
        _level = new Level();
        _stats = new Stats();
        _inventory = new Inventory();
    }

    // Getters (if neccessary in future)
    public Level GetLevel() => _level;
    public Stats GetStats() => _stats;
    public Inventory GetInventory() => _inventory;

    // Methods
    public void onNewLvl(int level)
    {
        // Messages. Soon will be as <srting> events
        Console.WriteLine("New level! {level}");
        Console.WriteLine($"+2 available stats points!");
        // 
        _stats.AddAP();
    }
    public void AddExp(int exp)
    {
        List<int> newLevels = _level.AddExp(exp);
        foreach (int level in newLevels)
            onNewLvl(level);
    }

    public void Add(Item item) => _inventory.Add(item);
    
    public void Use(Item item) => _inventory.Use(item);

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

    public void About()
    {
        Console.WriteLine($"My profile:");
        Console.WriteLine($"Name: {name}");
        /*
         * todo
        Console.WriteLine($"Race: {rase}");
        Console.WriteLine($"Type: {type}");
        */

        _level.GetInfo();
        _stats.GetInfo();
    }
}