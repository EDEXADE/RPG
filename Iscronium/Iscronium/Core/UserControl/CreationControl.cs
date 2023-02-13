using Iscronium.Models.Races;
using Iscronium.Models.Units;

namespace Iscronium.Core.UserControl;

public class CreationControl
{
    private Core core;
    private int ID;
    
    public CreationControl(Core core)
    {
        this.core = core;
        ID = 1;
    }

    private (int, Player) CreatePlayer(string name, Race race)
    {
        int id = ID++;
        Player player = new Player(name, race);
        return (id, player);
    }
    
    public Player NewPlayer(string name, Race race)
    {
        // todo
        var (id, player) = CreatePlayer(name, race);
        core._players.Add(id, player);
        return player;
    }
}