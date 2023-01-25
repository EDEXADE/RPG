namespace Iscronium.Models.Weapons;

// Class of concretely sword. (Weapon)
public class Sword: Weapon
{
    private string Name { get; }
    private string Description { get; }
    /*
    private readonly List<Bonus> _bonuses;
    */
    public Sword(string name, string description/*, List<Bonus> bonuses*/)
    {
        Name = name;
        Description = description;
        /*_bonuses = bonuses;*/
    }

    protected override (string, string) GetInfo() => (Name, Description);
}