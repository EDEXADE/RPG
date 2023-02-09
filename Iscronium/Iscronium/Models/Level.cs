namespace Iscronium.Models;

public class Level
{
    // Const variables
    private const int InitDifExp = 500; // Really?? 500???

    // Properties
    public int CurrentLevel { get; private set; }
    public int CurrentExp { get; private set; }
    public int MaxExp { get; private set; }
    
    // Constructor
    public Level()
    {
        CurrentLevel = 1;
        CurrentExp = 0;
        MaxExp = InitDifExp;
    }
    
    public Level(Level level, int exp)
    {
        CurrentLevel = level.CurrentLevel;
        CurrentExp = level.CurrentExp;
        MaxExp = level.MaxExp;
        AddExp(exp);
    }
    
    // Methods
    private void LevelUp()
    {
        // changing Level state
        CurrentLevel += 1;
        CurrentExp = 0;
        MaxExp += InitDifExp;
    }

    private void AddExp(int exp)
    {
        // System of auto updating lvl system
        int toNextLvl;
        while (exp >= (toNextLvl = MaxExp - CurrentExp))
        {
            exp -= toNextLvl;
            LevelUp();
        }
        CurrentExp += exp;
    }
    
    // there or maybe in Player?
    public void GetInfo()
    {
        Console.WriteLine($"Level: {CurrentLevel}");
        Console.WriteLine($"Experience: [{CurrentExp}/{MaxExp}]");
    }
}
