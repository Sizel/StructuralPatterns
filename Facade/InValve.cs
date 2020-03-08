using System;

namespace Facade
{
	internal class InValve
	{
		internal void open()
		{
			Console.WriteLine("Opening the in valve. Water is starting to flow.");
		}

		internal void close()
		{
			Console.WriteLine("Closing the in valve. Water is no more flowing.");
		}
	}
}