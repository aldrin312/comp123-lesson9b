using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson9b
{
    /// <summary>
    /// This is the Human Abstract class
    /// </summary>
    public abstract class Human
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)
        private string _name;

        // PUBLIC PROPERTIES -----------------------------------------
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

        // CONSTRUCTORS -----------------------------------------------

        /// <summary>
        /// This is the constructor for the Human abstract class.
        /// It requires one parameter - name (string).
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        // PUBLIC ABSTRAC TMETHOD
        public abstract void DisplaySkills();

		public abstract void Trains();
    }
    
}
