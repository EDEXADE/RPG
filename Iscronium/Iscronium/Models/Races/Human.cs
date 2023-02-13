using Iscronium.Models.Bonuses;
using Iscronium.Models.Statss;

namespace Iscronium.Models.Races;

public class Human: Race
{
    public override RaceType CurrentRace => RaceType.Human;
    
    public override string Description => "Simple Human. In any situation you remain yourself...";

    public override List<SimpleStatBonus> RaceBonuses { get; } =
        new()
        {
            new SimpleStatBonus(StatType.Intellect, +2),
        };
}