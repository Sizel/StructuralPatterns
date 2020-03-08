using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
	class WashingMachineFacade
	{
		public WashingMachineFacade()
		{
			InValve = new InValve();
			OutValve = new OutValve();
			HeatingElement = new HeatingElement();
			Drum = new Drum();
		}

		public InValve InValve { get; set; }
		public OutValve OutValve { get; set; }
		public HeatingElement HeatingElement { get; set; }
		public Drum Drum { get; set; }

		public void Wash()
		{
			InValve.open();

			InValve.close();

			HeatingElement.heat();

			Drum.spin();

			OutValve.open();

			OutValve.close();

			InValve.open();

			InValve.close();

			Drum.spin();

			OutValve.open();

			OutValve.close();

		}

	}
}
