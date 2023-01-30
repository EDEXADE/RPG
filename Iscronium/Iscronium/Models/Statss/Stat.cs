namespace Iscronium.Models.Statss;

public struct Stat
{
    const int INIT_VALUE = 2;

    //private int value = 2;
    public string Name { get; }
    public StatType Type { get; }
    public int Value { get; private set; }

    
    public Stat(string name = "", StatType type = StatType.Strength)
    { 
        /* rlly? */
        Type = type;
        Name = name;
        Value = INIT_VALUE;
    }
    
    // why have no int parameter? Soon will become clearer.. todo
    public void Add() => Value += 1;
    public int Reset()
    {
        int difference = Value - INIT_VALUE;
        Value = INIT_VALUE;
        return difference;
    }
}