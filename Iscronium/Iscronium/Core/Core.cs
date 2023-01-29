using System.Threading.Channels;
using Iscronium.Models.Units;

namespace Iscronium.Core;

public class Core
{
    private readonly Player _player;
    public Core()
    {
        _player = CreateCharacter();
        Start();
    }
    
    private Player CreateCharacter()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine() ?? "Player";
        return new Player(name);
    }

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