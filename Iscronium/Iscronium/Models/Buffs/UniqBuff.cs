using Iscronium.Models.Statss;

namespace Iscronium.Models.Buffs;

public class UniqBuff: BuffDecorator
{
    private int _amount;
    private StatType _type;
    public UniqBuff(StatType type, int amount) : base(null)
    {
        _amount = amount;
        _type = type;
    }
    public UniqBuff(IBuff buff, StatType type, int amount) : base(buff)
    {
        _amount = amount;
        _type = type;
    }
    public override void ApplyBuff(Stats stats)
    {
        base.ApplyBuff(stats);
        for (int i = 0; i < _amount; i++)
            stats.Add(_type);
    }
}