using Iscronium.Models.Units;
using Iscronium.Models.Units.Races;

namespace Iscronium.Core.UserControl;

public class CreationControl
{
    private int ID;
    
    public CreationControl()
    {
        ID = 1;
    }

    public (int, Player) CreatePlayer(string name, Race race)
    {
        int id = ID++;
        Player player = new Player(name, race);
        return (id, player);
    }
}