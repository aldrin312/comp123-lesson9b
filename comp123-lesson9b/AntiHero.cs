using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aldrin Fernandez
 * Date: july 20 , 2017
 * Description : this is the anti hero class
 * Version: created the anti hero class and implement that ihasmalice and ihaskarma interface
 */
namespace comp123_lesson9b
{
	public class AntiHero : SuperHuman, IHasKarma, iHasMalice, ITrainable
	{
		//PRIVATE INTANCE VARIABLES
		private int _karma;
		private int _malice;
		//PUBLIC PROTPERTIES\
		
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
		//CONSTRUCTOR----------------------------------------------------------------
		/// <summary>
		/// this is the constructor for the anito hero class
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="karma"></param>
		/// <param name="malice"></param>
		public AntiHero(string name, int karma, int malice) 
			: base(name)
		{
			this.Karma = karma;
			this.Malice = malice;
		}


		public void Train()
		{
			Console.WriteLine("Not Implemented");
		}



		//PUBLIC METHODS

		//PRIVATE METHODS

	}
}