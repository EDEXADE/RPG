    using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Iscronium.Models.Statss;

public class Stats
{
    // Const
    private const int InitValue = 2;
    private static readonly List<StatType> InitValues = new()
    {
        StatType.Strength, 
        StatType.Dexterity, 
        StatType.Intellect, 
        StatType.Stamina,
    };
    
    // Fields and/or 
    private Dictionary<StatType, int> _stats { get; }
    public int FreePoints { get; private set; }
    
    // Getters
    public StatType[] GetStats() => _stats.Keys.ToArray();
    public int GetStat(StatType type)
    {
        if (_stats.TryGetValue(type, out int value))
            return value;

        Console.WriteLine("Wow! U try to increase this stat, but u don't have it");
        return 0;
        // todo 
        // need report for bug or abuse 
        //? throw new Exception("Wow! U try to get this stat, but u don't have it");
    }

    // Constructor
    public Stats()
    {
        _stats = new Dictionary<StatType, int>(); 
        foreach (var statType in InitValues)
            _stats.Add(statType, InitValue);
        
        FreePoints = 5;
    }

    // Methods
    public void AddFP(int points = InitValue) => FreePoints += points;

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
    
    public void Reset()
    {
        foreach (var statType in InitValues)
        {
            int points = _stats[statType] - 2;
            _stats[statType] = 2;
            FreePoints += points;
        }
    }

    public void GetInfo()
    {
        Console.WriteLine("Stats:");
        foreach (var (stat, value) in _stats)
            Console.WriteLine($"{stat} - {value}");
        Console.WriteLine($"Available points: {FreePoints}");
    }
}