using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Aldrin Fernandez
 * Date:July , 2017
 * Description: THis is the human abstract class
 *  Version 0.1 - Create human abstract class
 */
namespace comp123_lesson9b
{
    /// <summary>
    ///  This is the human abstract class
    /// </summary>
    public abstract class Human
    {

        //PRIVATE INTANCE VARIABLES(FIELDS)
        private string _name;


        //PUBLIC PROTPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //CONSTRUCTOR----------------------------------------------------------------

            /// <summary>
            /// this is the main constructor
            /// it takes pme [ara,eter - name (string)
            /// </summary>
            /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        //PUBLIC METHIDS

        //PRIVATE METHODS
    }
}
