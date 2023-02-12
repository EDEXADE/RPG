using System.Threading.Channels;
using Iscronium.Core;
using Iscronium.Models.Items;
using Iscronium.Models.Statss;
using Iscronium.Models.Units;

Item ironSword = new Weapon("Iron Sword", "Simple sword. Was made in India by Aleo Rosakke", null);
Item ironSword2 = new Weapon("Gold Sword", "Is it real gold? Maybe sell it?", null);

Core system = new Core();
Player player = system.CreatePlayer("Player");
system.AddExp(player, 1000);
// (1 0/500) + 1000 = (2 0/1000) + 500 = 2 500/1000
system.AddExp(player, 5000);
// (2 500/1000) + 5000 = (3 0/1500) + 4500 = (4 0/2000) + 3000 = (5 0/2500) + 1000 = (5 1000/2500)
Console.WriteLine(player.Level.CurrentLevel);
// 5 lvl -> 5 + (5 - 1) * 2 = 13
Console.WriteLine(player.Stats.FreePoints);