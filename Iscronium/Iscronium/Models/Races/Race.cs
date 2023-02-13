using Iscronium.Models.Bonuses;

namespace Iscronium.Models.Races;

public abstract class Race
{
    public abstract RaceType CurrentRace { get; }
    public abstract string Description { get; }
    public abstract List<SimpleStatBonus> RaceBonuses { get; }
}