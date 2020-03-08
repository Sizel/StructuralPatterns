using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
	public class RealBookParser : IBookParser
	{
		public string Path { get; private set; }
		private int _pages;

		public RealBookParser(string path)
		{
			Path = path;
			Parse();
		}

		private void Parse()
		{
			// Parsing
			_pages = (new Random()).Next(1, 250);
		}

		public int GetNumPages()
		{
			return _pages;
		}
	}
}
