using System.Collections.Immutable;

namespace Iscronium.Models.Statss;

public class Stats
{
    private const int InitValue = 2;
    // try to use Enum instead string
    private static readonly List<StatType> InitValues = new()
    {
        StatType.Strength, StatType.Dexterity, StatType.Intellect, StatType.Stamina,
    };

    private readonly Dictionary<StatType, int> _stats;

    public ImmutableDictionary<StatType, int> GetStats()
    {
        return _stats.ToImmutableDictionary();
    }
    public int FreePoints { get; private set; }

    public Stats()
    {
        _stats = new Dictionary<StatType, int>(); 
        foreach (var statType in InitValues)
            _stats.Add(statType, InitValue);
        
        FreePoints = 5;
    }

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