using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	class CarWasherComponent : ICleanComponent
	{
		public void Clean(Car car)
		{
			Console.WriteLine("Car is washed");
			car.IsWashed = true;
		}
	}
}
