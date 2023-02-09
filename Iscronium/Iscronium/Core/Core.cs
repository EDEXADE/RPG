
using Iscronium.Core.UserControl;
using Iscronium.Models.Units;

namespace Iscronium.Core;

public class Core
{
    private readonly CreationControl _crControl;
    private readonly ExperienceControl _expControl;
    
    private readonly Dictionary<int, Player> _players;
    
    public Core()
    {
        _crControl = new CreationControl();
        _expControl = new ExperienceControl();

        _players = new Dictionary<int, Player>();
    }

    public Player CreatePlayer(string name)
    {
        var (id, player) = _crControl.CreatePlayer(name);
        _players.Add(id, player);
        return player;
    }

    public void AddExp(Player player, int exp) => _expControl.AddExp(player, exp);

    public void Start()
    {
        Console.WriteLine("new - create item");
        string? input;
        while ((input = Console.ReadLine()) != "exit")
        {
            switch (input)
            {
                case "new":
                    
                    break;
                case "add":
                    
                    break;
                
                default:
                    break;
            }
        }
    }
}