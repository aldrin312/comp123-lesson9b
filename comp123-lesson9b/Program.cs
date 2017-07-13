using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
