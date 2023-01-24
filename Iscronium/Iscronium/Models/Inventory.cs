using System.ComponentModel.Design;

namespace Iscronium.Models;

public class Inventory
{
    public List<(IItem, int)> Slots;
    public int MaxSlots { get; private set; }

    public (IItem, int) this[int index]
    {
        get
        {
            if (index < Slots.Count)
                return Slots[index];
            throw new Exception("Пусто..");
        }
    }
    
    public Inventory(int maxCount = 10)
    {
        Slots = new List<(IItem, int)>();
        MaxSlots = maxCount;
    }

    public bool Add(IItem item)
    {
        // return index of free slot (< 16 ones) of same item
        // or -1 if no free slots
        int index =
            Slots.FindIndex(slot => slot.Item1 == item && slot.Item2 < 16);
        // True if there is free slot (< 16 ones) of same item
        bool hasSameFree = (index != -1);

        if (hasSameFree)
        {
            var slot = Slots[index].Item1;
            var count = Slots[index].Item2;
            Slots[index] = (slot, count + 1);
            return true;
        }
        
        if (Slots.Count < MaxSlots)
        {
             Slots.Add((item, 1));
             return true;
        }
        
        return false;
    }

    public bool Delete()
    {
        // todo
        return true;
    }
    
    public void Resize(int slots)
    {
        MaxSlots += slots;
    }
}