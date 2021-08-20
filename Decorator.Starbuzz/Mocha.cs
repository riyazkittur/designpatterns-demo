using System;
using System.Configuration;

	/// <summary>
	/// Summary description for Mocha.
	/// </summary>
	public class Mocha : CondimentDecorator
	{
		Beverage beverage;
		
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string GetDescription()
		{
			return beverage.GetDescription() + ", Mocha";
		}

		public override double Cost()
		{
			return GetSize(base.Size);
		}

		private double GetSize(BeverageSize size)
		{
			switch(size)
			{
				case BeverageSize.TALL:
					return 	.4 + beverage.Cost();
				case BeverageSize.GRANDE:
					return  .33 + beverage.Cost();
				case BeverageSize.VENTI:
					return  .22 + beverage.Cost();
				default:
					return .20;
			}
		}

	}
