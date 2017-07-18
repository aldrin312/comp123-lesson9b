using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// version- overloaded the > and < operator for the power
namespace comp123_lesson9b
{
    /// <summary>
    /// The Power class contains the data and structure of the each Super Power.
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------------

        /// <summary>
        /// This is the Power construtor.
        /// Takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }


		//overlaoded operators

		/// <summary>
		/// This method overlaids the > for use with the power class
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		/// <returns></returns>
		public static bool operator >(Power lhs, Power rhs)
		{
			return (lhs.Rank > rhs.Rank);
		}


		/// <summary>
		/// This method overlaids the < for use with the power class
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		/// <returns></returns>
		public static bool operator <(Power lhs, Power rhs)
		{
			return (lhs.Rank < rhs.Rank);

		}

	}
}
