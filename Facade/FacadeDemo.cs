using System;

namespace Facade
{
	class FacadeDemo
	{
		static void Main(string[] args)
		{
			WashingMachineFacade washingMachineFacade = new WashingMachineFacade();
			washingMachineFacade.Wash();
		}
	}
}
