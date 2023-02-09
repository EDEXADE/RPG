using Iscronium.Models.Statss;
using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;

namespace Iscronium.Models.Units;

public class Player: Unit, IInteractive
{
    // Fields
    public Level Level { get; private set; }
    public readonly Stats Stats;
    public readonly Inventory Inventory;

    // Constructor
    public Player(string name)
        : base(name, UnitType.Player)
    {
        Level = new Level();
        Stats = new Stats();
        Inventory = new Inventory();
    }
    
    // Getters
    
    
    // Methods
    private void OnNewLvl(int level)
    {
        // Messages. Soon will be as <string> events
        Console.WriteLine($"New level! {level}");
        Console.WriteLine("+2 available stats points!");
        
        // Change state other subclasses
        Stats.AddFP();
    }
    
    public void AddExp(int exp)
    {
        int last_level = Level.CurrentLevel;
        Level = new Level(Level, exp);
        for (int i = last_level + 1; i <= Level.CurrentLevel; i++)
            OnNewLvl(i);
    }
    
    public void Use(Item item) => Inventory.Use(item);

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
         * todo.
        Console.WriteLine($"Race: {race}");
        Console.WriteLine($"Type: {type}");
        */

        Level.GetInfo();
        Stats.GetInfo();
    }
}