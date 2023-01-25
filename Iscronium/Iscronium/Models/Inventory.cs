namespace Iscronium.Models;

public class Inventory
{
    private List<(Item, int)> _slots;
    private int MaxSlots { get; set; }

    public (Item, int) this[int index]
    {
        get
        {
            if (index < _slots.Count)
                return _slots[index];
            throw new Exception("Пусто..");
        }
    }
    
    public Inventory(int maxCount = 10)
    {
        _slots = new List<(Item, int)>();
        MaxSlots = maxCount;
    }

    public bool Add(Item item)
    {
        // return index of free slot (< 16 ones) of same item
        // or -1 if no free slots
        int index =
            _slots.FindIndex(slot => slot.Item1 == item && slot.Item2 < 16);
        // return True if there is free slot (< 16 ones) of same item
        bool hasSameFree = (index != -1);

        if (hasSameFree)
        {
            var slot = _slots[index].Item1;
            var count = _slots[index].Item2;
            _slots[index] = (slot, count + 1);
            return true;
        }
        
        if (_slots.Count < MaxSlots)
        {
             _slots.Add((item, 1));
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