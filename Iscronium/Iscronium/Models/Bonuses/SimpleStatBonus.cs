using Iscronium.Models.Statss;

namespace Iscronium.Models.Bonuses;

public readonly struct SimpleStatBonus
{
    public readonly StatType Stat;
    public readonly int Value;

    public SimpleStatBonus(StatType stat, int value)
    {
        Stat = stat;
        Value = value;
    }
}