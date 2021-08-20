using System;


	/// <summary>
	/// Summary description for NoCommand.
	/// </summary>
	public class NoCommand : Command
	{
		public NoCommand()
		{}

		#region Command Members
		public object Execute()
		{
			return null;
		}
		#endregion
	}

