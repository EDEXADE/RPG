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
    public void AddExp(int exp)
    {
        int toNextLvl;
        while (exp >= (toNextLvl = MaxExp - CurrentExp))
        {
            exp -= toNextLvl;
            
            CurrentLevel += 1;
            CurrentExp = 0;
            MaxExp += INIT_DIF_EXP;
        }
        CurrentExp += exp;
    }
    
    public void GetInfo()
    {
        Console.WriteLine($"Level: {CurrentLevel}");
        Console.WriteLine($"Experience: [{CurrentExp}/{MaxExp}]");
        Console.WriteLine();
    }
}