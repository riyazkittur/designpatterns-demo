using System;


	/// <summary>
	/// Summary description for ISubject.
	/// </summary>
	public interface ISubject
	{
		void RegisterObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObserver();
	}

