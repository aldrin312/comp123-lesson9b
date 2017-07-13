﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson9b
{
    /// <summary>
    /// This is the SuperHuman sub class.
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // returns a reference to the Powers List
            }
        }


        // CONSTRUCTORS
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method adds a Power to the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank: " + power.Rank);
            }
        }
        /// <summary>
        /// Overriden the built in TOstring method
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "=====================================\n";
            outputstring += "SuperHuman Name: " + this.Name + "\n";
            outputstring += "======================================\n";
            foreach (Power power in this.Powers)
            {
                outputstring += "======================================\n";
                outputstring += "Power: " + power.Name + "Rank: " + power.Rank + "\n";
                outputstring += "======================================\n";
            }


            return outputstring;
        }

        //public overide
        /// <summary>
        /// This is the DisplaySKills method
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}