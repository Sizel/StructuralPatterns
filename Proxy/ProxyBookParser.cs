using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
	class ProxyBookParser : IBookParser
	{
		private IBookParser _bookParser = null;

		public string Path { get; private set; }

		public ProxyBookParser(string path)
		{
			Path = path;
		}

		public int GetNumPages()
		{
			if (_bookParser == null)
			{
				_bookParser = new RealBookParser(Path);
			}

			return _bookParser.GetNumPages();
		}
	}
}
