using Iscronium.Models.Bonuses;

namespace Iscronium.Models.Units.Races;

public abstract class Race
{
    public abstract RaceType CurrentRace { get; }
    public abstract string Description { get; }
    public abstract List<Bonus> RaceBonuses { get; }
}