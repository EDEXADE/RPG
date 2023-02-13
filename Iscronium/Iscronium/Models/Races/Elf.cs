using Iscronium.Models.Bonuses;
using Iscronium.Models.Statss;

namespace Iscronium.Models.Races;

public class Elf: Race
{
    public override RaceType CurrentRace => RaceType.Elf;

    public override string Description => "Forest cute and nimble creatures... Be careful, who knows what's on their minds?";

    public override List<SimpleStatBonus> RaceBonuses { get; } =
        new()
        {
            new SimpleStatBonus(StatType.Dexterity, +2),
        };
}