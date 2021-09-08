using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var Games = new List <string>();

            Games.Add("Minecraft");
            Games.Add("Skyrim: Elder Scrolls V");
            Games.Add("Halo");
            Games.Add("Cyberpunk 2077");
            Games.Add("Fallout 4");
            Games.Add("Legend of Zelda: Breath of The Wild");
            Games.Add("DarkSouls 3");
            Games.Add("The Outer Worlds");
            Games.Add("Star Wars Battlefront 2");
            Games.Add("Kingdom Come Deliverence");
            Games.Add("GreedFall");
            Games.Add("Mordhau");
            Games.Add("Chivalry 2");


            var gameList = Games.OrderBy(x=>x);

            foreach (var y in gameList)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("---------------------------");





        }
    }
}
