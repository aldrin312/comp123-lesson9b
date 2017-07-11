using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Aldrin Fernandez
 * Date:July , 2017
 * Description: THis is the superhuman class that  extend the human abstrac class
 *  Version 0.2 - Added the initialize method
 */

namespace comp123_lesson9b
{
    /// <summary>
    /// THis is the SuperHuman Class
    /// </summary>
    public class SuperHuman : Human
    {

        //PRIVATE INTANCE VARIABLES(FIELDS)

        private List<Power> _powers;


        //PUBLIC PROTPERTIES

        //CONSTRUCTOR----------------------------------------------------------------

        /// <summary>
        /// This is the main constructor for super human class
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        //PUBLIC METHIDS

            /// <summary>
            /// this initialize, instantiate and assign values to class
            /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }


        //PRIVATE METHODS
    }
}
