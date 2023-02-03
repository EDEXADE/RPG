namespace Iscronium.Models;

public class Level
{
    // Const variables
    private const int INIT_DIF_EXP = 500; // Really?? 500???

    // Properties
    public int CurrentLevel { get; private set; }
    public int CurrentExp { get; private set; }
    public int MaxExp { get; private set; }

    // Constructor
    public Level()
    {
        CurrentLevel = 1;
        CurrentExp = 0;
        MaxExp = INIT_DIF_EXP;
    }
    
    // Methods
    private void LevelUp()
    {
        CurrentLevel += 1;
        CurrentExp = 0;
        MaxExp += INIT_DIF_EXP;
    }

    public List<int> AddExp(int exp)
    {
        List<int> newLevels = new();

        int toNextLvl;
        while (exp >= (toNextLvl = MaxExp - CurrentExp))
        {
            exp -= toNextLvl;

            LevelUp();
            newLevels.Add(CurrentLevel);
        }
        CurrentExp += exp;

        // count of new levels
        return newLevels;
    }
    
    public void GetInfo()
    {
        Console.WriteLine($"Level: {CurrentLevel}");
        Console.WriteLine($"Experience: [{CurrentExp}/{MaxExp}]");
    }
}
