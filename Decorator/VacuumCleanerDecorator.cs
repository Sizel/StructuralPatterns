using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	class CarVacuumCleanerDecorator : CarCleanerDecorator
	{
		public CarVacuumCleanerDecorator(ICleanComponent cleanerComponent) : base(cleanerComponent) { }

		public override void Clean(Car car)
		{
			VacuumClean(car);
			_cleanerComponent.Clean(car);
		}

		private void VacuumClean(Car car)
		{
			Console.WriteLine("Car is vacuumed");
			car.IsVacuumed = true;
		}
	}
}
