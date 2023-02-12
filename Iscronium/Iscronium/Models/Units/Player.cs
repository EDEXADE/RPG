using Iscronium.Models.Buffs;
using Iscronium.Models.Statss;
using Iscronium.Models.Items;
using Iscronium.Models.Units.Actions;
using Iscronium.Models.Units.Races;

namespace Iscronium.Models.Units;

public class Player: Unit, IInteractive
{
    // Fields and Properties
    public Race Race { get; }
    
    public Level Level { get; private set; }
    public Stats Stats { get; }
    private Inventory Inventory { get; }

    // Constructor
    public Player(string name, Race race)
        : base(name, UnitType.Player)
    {
        Race = race;
        
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
        int lastLevel = Level.CurrentLevel;
        Level = new Level(Level, exp);
        for (var level = lastLevel + 1; level <= Level.CurrentLevel; level++)
            OnNewLvl(level);
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
        Console.WriteLine("My profile:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Race: {Race.CurrentRace}");

        Level.GetInfo();
        Stats.GetInfo();
    }
}