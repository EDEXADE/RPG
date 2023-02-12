    using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Iscronium.Models.Statss;

public class Stats2
{
    // Fields and/or Properties
    public int Strength { get; private set; }
    public int Dexterity { get; private set; }
    public int Intellect { get; private set; }
    public int Stamina { get; private set; }
    //..
    
    public int FreePoints { get; private set; }


    public Stats2()
    {
        Strength = 2;
        Dexterity = 2;
        Intellect = 2;
        Stamina = 2;
        
        FreePoints = 5;
    }

    public void AddFP(int points = 2) => FreePoints += points;
    /*
    public bool Add(StatType statName)
    {
        if (FreePoints <= 0)
        {
            Console.WriteLine("You don't have free points");
            return false;
        }
        
        if (!_stats.ContainsKey(statName))
        {
            Console.WriteLine("Wow! U try to increase this stat, but u don't have it");
            // todo 
            // need report for bug or abuse 
            //? throw new Exception("Wow! U try to use this item, but u don't have it");
            return false;
        }

        _stats[statName]++;
        FreePoints--;
        return true;
    }
    */
    public void Reset()
    {
        int dif = 0;
        dif += Strength + Dexterity + Intellect + Stamina - 8;
        Strength = Dexterity = Intellect = Stamina = 2;
        FreePoints += dif;
    }
    /*
    public void GetInfo()
    {
        Console.WriteLine("Stats:");
        foreach (var (stat, value) in _stats)
            Console.WriteLine($"{stat} - {value}");
        Console.WriteLine($"Available points: {FreePoints}");
    }
    */
}