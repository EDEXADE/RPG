using Iscronium.Models.Bonuses;
using Iscronium.Models.Statss;

namespace Iscronium.Models.Races;

public class Orc: Race
{
    public override RaceType CurrentRace => RaceType.Orc;

    public override string Description => "Green, big and strong. That's just intelligence...";

    public override List<SimpleStatBonus> RaceBonuses { get; } =
        new()
        {
            new SimpleStatBonus(StatType.Strength, +3),
            new SimpleStatBonus(StatType.Dexterity, -1),
            new SimpleStatBonus(StatType.Intellect, -2),
            new SimpleStatBonus(StatType.Stamina, +2),
        };
}