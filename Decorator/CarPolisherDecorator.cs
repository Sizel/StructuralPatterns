using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	class CarPolisherDecorator : CarCleanerDecorator
	{
		public CarPolisherDecorator(ICleanComponent cleanerComponent) : base(cleanerComponent) { }

		public override void Clean(Car car)
		{
			PolishCar(car);
			_cleanerComponent.Clean(car);
		}

		private void PolishCar(Car car)
		{
			Console.WriteLine("Car is polished");
			car.IsPolished = true;
		}
	}
}
