
using Iscronium.Core.UserControl;
using Iscronium.Models.Races;
using Iscronium.Models.Units;

namespace Iscronium.Core;

public class Core
{
    public readonly CreationControl _crControl;
    public readonly ExperienceControl _expControl;
    
    public readonly Dictionary<int, Player> _players;
    
    private Core()
    {
        _crControl = new CreationControl(this);
        _expControl = new ExperienceControl();

        _players = new Dictionary<int, Player>();
    }

    private static readonly Core core = new Core();
    
    public static Core Initialize()
    {
        return core;
    }
    
    public void Start()
    {

    }
}