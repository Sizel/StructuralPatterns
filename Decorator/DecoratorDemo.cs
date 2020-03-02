using System;

namespace Decorator
{
	class DecoratorDemo
	{
		static void Main(string[] args)
		{
			CarVacuumCleanerDecorator vacuumCleanerAndWasher = new CarVacuumCleanerDecorator
															  (new CarWasherComponent());

			CarPolisherDecorator polisherAndvacuumCleanerAndWasher = new CarPolisherDecorator
																	(new CarVacuumCleanerDecorator
																	(new CarWasherComponent()));

			Car car = new Car();
			vacuumCleanerAndWasher.Clean(car);

			Console.WriteLine();

			polisherAndvacuumCleanerAndWasher.Clean(car);
		}
	}
}
