using Iscronium.Models.Bonuses;
using Iscronium.Models.Statss;

namespace Iscronium.Models.Units.Races;

public class Human: Race
{
    public override RaceType CurrentRace { get; } = RaceType.Human;
    public override string Description { get; } = "Simple Human. In any situation you remain yourself";

    public override List<Bonus> RaceBonuses { get; } =
        new List<Bonus>()
        {
            new (StatType.Dexterity, 1), 
            new (StatType.Dexterity, 1), 
            new (StatType.Intellect, 1), 
            new (StatType.Stamina, 1),
        };
}