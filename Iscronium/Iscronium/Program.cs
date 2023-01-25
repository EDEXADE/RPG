using System;
using Iscronium.Models;
using Iscronium.Models.Weapons;

Console.WriteLine("Hello, World!");
Item ironSword = new Sword("Iron Sword", "Simple sword. Was made in India by Aleo Rosakke");
Console.WriteLine(ironSword.GetType());
ironSword.Use();
Item ironSword2 = new Sword("Gold Sword", "Is it real gold? Maybe sell it?");
Console.WriteLine(ironSword.GetType());
ironSword.Use();