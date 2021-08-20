using System;

	/// <summary>
	/// Summary description for Mozzerella.
	/// </summary>
	public class Mozzerella : ICheese
	{
		#region Constructor
		public Mozzerella()
		{}
		#endregion//Constructor
		
		#region ICheese Members

		public string toString()
		{
			return "Mozzerella Cheese";
		}

		#endregion
	}
