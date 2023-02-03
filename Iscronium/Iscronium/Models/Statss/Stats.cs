namespace Iscronium.Models.Statss;

public class Stats
{
    // try to use Enum instead string
    /*
    private readonly List<string> INIT_VALUES2 = new List<string>()
    {
        "Сила", "Ловкость", "Интеллект", "Выносливость",
    };
    */
    
    private readonly List<StatType> INIT_VALUES = new List<StatType>()
    {
        StatType.Strength, StatType.Dexterity, StatType.Intellect, StatType.Stamina,
    };
    
    /* private Dictionary<string, Stat> _stats; */
    private Dictionary<StatType, Stat> _stats;

    private int FreePoints;
    
    public Stats()
    {
        FreePoints = 5;
        
        /*
        _stats = new Dictionary<string, Stat>(); 
        foreach (var stat_name in INIT_VALUES)
        {
            Stat stat = new Stat(stat_name);
            _stats.Add(stat_name, stat);
        }
        */
        
        _stats = new Dictionary<StatType, Stat>(); 
        foreach (var statType in INIT_VALUES)
        {
            Stat stat = new Stat("", statType);
            _stats.Add(statType, stat);
        }
    }

    public void AddAP(int points = 2) => FreePoints += points;

    public bool Add(/*string stat_name*/ StatType stat_name)
    {
        if (FreePoints <= 0)
        {
            Console.WriteLine("You don't have free points");
            return false;
        }
        if (!_stats.ContainsKey(stat_name))
        {
            Console.WriteLine("Wow! U try to increase this stat, but u don't have it");
            // todo 
            // need report for bug or abuse 
            //? throw new Exception("Wow! U try to use this item, but u don't have it");
            return false;
        }
            
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

    public void GetInfo()
    {
        Console.WriteLine("Stats:");
        foreach (var statName in _stats.Values)
            Console.WriteLine($"{statName.Type} - {statName.Value}");
        Console.WriteLine($"Available points: {FreePoints}");
    }
}