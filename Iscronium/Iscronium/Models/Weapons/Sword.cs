namespace Iscronium.Models.Weapons;

public class Sword: Weapon
{
    public Sword(string name, string description) : base(name, description)
    {
        Name = name;
        Description = description;
    }
}