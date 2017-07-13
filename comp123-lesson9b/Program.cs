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
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.Powers.Add(new Power("Invisibilty", 30));
            Console.WriteLine(superHuman.ToString());

        }
    }
}
