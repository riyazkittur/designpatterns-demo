using System;

	/// <summary>
	/// Summary description for EggPlant.
	/// </summary>
	public class EggPlant :IVeggies
	{
		#region Constructor
		public EggPlant()
		{}
		#endregion//Constructor
		
		#region IVeggies Members

		public string toString()
		{
			return "Egg Plant";
		}

		#endregion
	}
