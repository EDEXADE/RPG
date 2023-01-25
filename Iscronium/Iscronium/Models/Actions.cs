namespace Iscronium.Models;

public interface IEquipped
{
    public void PutOn();
    public void TakeOff();
        
    // ???
    /*
    public void PutOn(ItemType type, string name) => Console.WriteLine(f"Equipped {type} {name}");
    public void TakeOff(ItemType type, string name) => Console.WriteLine() => Console.WriteLine(f"Unequipped {type} {name}");
    */
}