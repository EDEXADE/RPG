using Iscronium.Models.Statss;

namespace Iscronium.Models.Buffs;

public abstract class BuffDecorator: IBuff
{
    private readonly IBuff? _buff;

    public BuffDecorator(IBuff? buff)
    {
        _buff = buff;
    }
    
    public virtual void ApplyBuff(Stats stats)
    {
        _buff?.ApplyBuff(stats);
    }
}