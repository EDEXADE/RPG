using Iscronium.Models.Items;
using Iscronium.Models.Items.Actions;

namespace Iscronium.Models;

public class Inventory
{
    // Const values
    const int INIT_MAX_COUNT = 10;
    
    // Properties
    private List<(Item, int)> _slots;
    private int MaxSlots { get; set; }

    // Index getter
    public (Item, int) this[int index]
    {
        get
        {
            if (index < _slots.Count)
                return _slots[index];
            throw new Exception("Пусто..");
        }
    }
    
    // Constructor
    public Inventory()
    {
        _slots = new List<(Item, int)>();
        MaxSlots = INIT_MAX_COUNT;
    }

    // Methods
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

    public void Use(Item item)
    {
        int index = _slots.FindLastIndex(slot => slot.Item1 == item);
        if (index == -1)
        {
            // todo 
            // need report for bug or abuse 
            //? throw new Exception("Wow! U try to use this item, but u don't have it");
            Console.WriteLine("Wow! U try to use this item, but u don't have it");
            return;
        }
        _slots[index].Item1.Use();
        if (_slots[index].Item1 is IConsumable)
            Remove(_slots[index].Item1);
    }
    
    public void Remove(Item item)
    {
        int index = _slots.FindLastIndex(slot => slot.Item1 == item);
        if (index == -1)
        {
            // todo 
            // need report for bug or abuse 
            //? throw new Exception("Wow! U try to delete this item, but u don't have it");
            Console.WriteLine("Wow! U try to delete this item, but u don't have it");
            return;
        }

        (Item neededItem, int count) = _slots[index];
        _slots[index] = (neededItem, count - 1);
    }
    
    private void Resize(int slots)
    {
        MaxSlots += slots;
    }
}