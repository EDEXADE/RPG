using System;
using Iscronium.Models;
using Iscronium.Models.Items;
using Iscronium.Models.Units;

Item ironSword = new Weapon("Iron Sword", "Simple sword. Was made in India by Aleo Rosakke", null);
Item ironSword2 = new Weapon("Gold Sword", "Is it real gold? Maybe sell it?", null);

Unit player = new Player("EDEXADE");

Unit anotherPlayer = new Player("Walker Esser");
((Player)player).Interact((Player)anotherPlayer);
((Player)player).Interact(anotherPlayer);


((Player)player).Use(ironSword);
((Player)player).Add(ironSword);
((Player)player).Use(ironSword);

((Player)player).Use(ironSword2);

