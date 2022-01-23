using System;
using System.Threading;

namespace TimerExample
{
	/// <summary>
	/// A delegate that defines the Notify event and Update method signatures.
	/// </summary>
	public delegate void NotifyEvent<T>(T subject, EventArgs args);

	/// <summary>
	/// The timer class (the subject).
	/// </summary>
	public class Timer
	{
		// the notify event
		public event NotifyEvent<Timer> Notify;

		/// <summary>
		/// Start the timer.
		/// </summary>
		public void Start()
		{
			// fire the notify event every second
			var thread = new Thread(() => {
				while (true)
				{
					if (Notify != null)
					{
						Notify(this, new EventArgs());
					}
					Thread.Sleep(1000);
				}
			});

			// start the timer
			thread.Start ();
		}
	}
}
