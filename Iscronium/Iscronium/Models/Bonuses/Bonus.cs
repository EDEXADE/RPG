using Iscronium.Models.Statss;

namespace Iscronium.Models.Bonuses;

public readonly struct Bonus
{
    public readonly StatType Stat;
    public readonly int Value;

    public Bonus(StatType stat, int value)
    {
        Stat = stat;
        Value = value;
    }
}