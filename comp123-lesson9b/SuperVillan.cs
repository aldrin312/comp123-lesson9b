using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 13, 2017
 * Description: This is supeVillain class that inherits from superhero class and implement the iHasMalice interface
 * Version: 0.3 - created supervillain class
 */
namespace comp123_lesson9b
{
    class SuperVillan : SuperHuman, iHasMalice
    {
        //private instances
        private int _malice;
        //public properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }

        public SuperVillan(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        //constructor

    }
}
