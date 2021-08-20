using System;


	/// <summary>
	/// Summary description for RateImplementation.
	/// </summary>
	public class RateImplementation
	{
		public RateImplementation()
		{}

		public static void Main()
		{
			RateSingleton rate = RateSingleton.GetInstance();
			Console.WriteLine(rate.CurrentRate);
		}
	}

