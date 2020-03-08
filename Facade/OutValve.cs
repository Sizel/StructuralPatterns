using System;

namespace Facade
{
	internal class OutValve
	{
		internal void open()
		{
			Console.WriteLine("Opening the out valve. Water is starting to flow out of the drum.");
		}

		internal void close()
		{
			Console.WriteLine("Closing the out valve. No more water in the drum.");
		}
	}
}