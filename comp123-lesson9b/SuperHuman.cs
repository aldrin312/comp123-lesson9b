using System;
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
            outputstring += "======================================\n";
            outputstring += "SuperHuman Name: " + this.Name + "\n";
			outputstring += "======================================\n";
			foreach (Power power in this.Powers)
            {
                outputstring += "Power: " + power.Name + "Rank: " + power.Rank + "\n";
                
            }
			outputstring += "======================================\n";
            return outputstring;
        }

		/// <summary>
		/// thi spirvate method returns the index of the pweor name in the power list
		/// if not found , returns -1
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Returns the index of tge ower ub tge power list by name</returns>
		private int _getPowerIndex(string name)
		{
			int index = 0;
			foreach (Power power in this.Powers) {
				if (name.Equals(power.Name))
				{
					break;
				}
				index++;
				if (this.Powers.Count == index)
				{
					index = -1; // this means that we did not find the power in the list
				}
			}

			return index;
		}
		
		public override void Trains()
		{
			Console.WriteLine("To be Implemented in the sub class");
		}
		
        //public overide
        /// <summary>
        /// This is the DisplaySKills method
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }


		/// <summary>
		/// this method returns a power that matches the pawer name
		/// if the power is not found, returns an anonymous power object with "power not found" with a rank of 0
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Power GetPower(string name)
		{
			int index = _getPowerIndex(name);

			if( index != -1)
			{
				return this.Powers[index];
			}
			return new Power("Power Not Found", 0);
			
		}
    }
}