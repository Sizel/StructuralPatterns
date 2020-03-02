using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	abstract class CarCleanerDecorator : ICleanComponent
	{
		protected ICleanComponent _cleanerComponent;

		public CarCleanerDecorator(ICleanComponent component)
		{
			_cleanerComponent = component;
		}

		public abstract void Clean(Car car);
	}
}
