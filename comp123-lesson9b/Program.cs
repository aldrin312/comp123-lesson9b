using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 13, 2017
 * Description: 
 * Version: - added a supervillain
 */

namespace comp123_lesson9b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude",50);
            superHero.Powers.Add(new Power("Teleportation", 50));
            superHero.Powers.Add(new Power("Invisibilty", 30));
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karam: "+superHero.Karma);

            SuperVillan superVillain = new SuperVillan("Super Bad Dude", 30);
            superVillain.Powers.Add(new Power("Flight", 60));
            superVillain.Powers.Add(new Power("Telekinisis", 30));
            superVillain.Powers.Add(new Power("Mind Control",20));
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);


			if (superHero is Human)
			{
				Console.WriteLine("superHero is a Human");
			}

			if (superHero is SuperHuman)
			{
				Console.WriteLine("superHero is a SuperHuman");
			}

			if (superHero is SuperHero)
			{
				Console.WriteLine("superHero is a SuperHero");
			}


			if (superHero is object)
			{
				Console.WriteLine("superHero is a object");
			}


			if (superHero is IHasKarma)
			{
				Console.WriteLine("superHero has Karma");
			}

			Console.WriteLine(superVillain._getPowerIndex("Spider senses")); 



		}
    }
}
