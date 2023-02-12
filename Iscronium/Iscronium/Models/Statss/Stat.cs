/* DEPRECATED */
/* Reason: it have no reasons))) we will created same object (but in dict) in /Stats.cs
/*
namespace Iscronium.Models.Statss;

public struct Stat
{
    private const int InitValue = 2;

    public StatType Type { get; }
    public int Value { get; private set; }

    
    public Stat(StatType type, int value = InitValue)
    { 
        Type = type;
        Value = value;
    }
    
    // why have no int parameter? Soon will become clearer.. todo//
    public void Add() => Value += 1;
    public int Reset()
    {
        int difference = Value - InitValue;
        Value = InitValue;
        return difference;
    }
}
*/