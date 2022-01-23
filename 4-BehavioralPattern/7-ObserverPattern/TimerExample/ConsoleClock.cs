using System;

namespace TimerExample
{
	/// <summary>
	/// The console clock class (the observer).
	/// </summary>
	public class ConsoleClock
	{
		/// <summary>
		/// Update the observer.
		/// </summary>
		/// <param name="sender">The timer sending the notify event.</param>
		/// <param name="args">The event arguments.</param>
		public void Update(Timer sender, EventArgs args)
		{
			Console.WriteLine (DateTime.Now.TimeOfDay);
		}
	}
}
