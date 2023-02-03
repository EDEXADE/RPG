using System;
using Iscronium.Models;
using Iscronium.Models.Items;
using Iscronium.Models.Units;

Item ironSword = new Weapon("Iron Sword", "Simple sword. Was made in India by Aleo Rosakke", null);
Item ironSword2 = new Weapon("Gold Sword", "Is it real gold? Maybe sell it?", null);

Unit me = new Player("EDEXADE");

Unit anotherPlayer = new Player("Walker Esser");
((Player)me).Interact((Player)anotherPlayer);
((Player)me).Interact(anotherPlayer);

((Player)me).Add(ironSword);
((Player)me).Use(ironSword);

((Player)me).Use(ironSword2);
ironSword2.GetInfo();

((Player)me).GetLevel().GetInfo();
((Player)me).GetLevel().AddExp(1000);
// (1 0/500) + 1000 = (2 0/1000) + 500 = 2 500/1000
((Player)me).GetLevel().AddExp(5000);
// (2 500/1000) + 5000 = (3 0/1500) + 4500 = (4 0/2000) + 3000 = (5 0/2500) + 1000 = (5 1000/2500)
((Player)me).GetLevel().GetInfo();
((Player)me).GetStats().GetInfo();
((Player)me).About();
    


