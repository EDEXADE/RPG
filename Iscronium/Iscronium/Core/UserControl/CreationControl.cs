using Iscronium.Models.Units;

namespace Iscronium.Core.UserControl;

public class CreationControl
{
    private int ID;
    
    public CreationControl()
    {
        ID = 1;
    }

    public (int, Player) CreatePlayer(string name)
    {
        int id = ID++;
        Player player = new Player(name);
        return (id, player);
    }
}