using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 13, 2017
 * Description: This is superhero class that inherits from a super hero class and implenet the iHasKarma interface
 * Version: 0.3 - created superhero class
 */
namespace comp123_lesson9b
{

    public sealed class SuperHero : SuperHuman, IHasKarma
    {
        // pirvate instancce variables or fields
        private int _karma;
        //public properties

        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        //constructors


            /// <summary>
            /// this is hte main construtor for the super hero class
            /// </summary>
            /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

        //privaet methods

        //publ2ic methods
    }
}
