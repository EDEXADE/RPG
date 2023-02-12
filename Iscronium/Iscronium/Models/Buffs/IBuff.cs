using Iscronium.Models.Statss;

namespace Iscronium.Models.Buffs;

public interface IBuff
{
    void ApplyBuff(Stats stats);
}