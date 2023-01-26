using System.ComponentModel;
using System.Diagnostics;

namespace Iscronium.Stats;

public struct Stat
{
    const int INIT_VALUE = 2;

    //private int value = 2;
    public string Name { get; }
    private int Value { get; set; }

    public Stat(string name)
    { 
        Name = name;
        Value = INIT_VALUE;
    }
    
    // why have no parameter? Soon will become clearer.. todo
    public void Add() => Value += 1;
    public int Reset()
    {
        int difference = Value - INIT_VALUE;
        Value = INIT_VALUE;
        return difference;
    }
}

public class Stats
{
    private readonly List<string> INIT_VALUES = new List<string>()
    {
        "Сила", "Ловкость", "Интеллект", "Выносливость",
    };
    
    private Dictionary<string, Stat> _stats;

    private int FreePoints;
    
    public Stats()
    {
        FreePoints = 5;
        
        _stats = new Dictionary<string, Stat>();
        foreach (var stat_name in INIT_VALUES)
        {
            Stat stat = new Stat(stat_name);
            _stats.Add(stat_name, stat);
        }
    }

    public bool Add(string stat_name)
    {
        if (!_stats.ContainsKey(stat_name) || FreePoints <= 0) return false;
            
        _stats[stat_name].Add();
        FreePoints--;
        return true;
    }
    
    public void Reset()
    {
        foreach (var stat_name in INIT_VALUES)
        {
            int points = _stats[stat_name].Reset();
            FreePoints += points;
        }
    }
}