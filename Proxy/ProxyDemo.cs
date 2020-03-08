namespace Proxy
{
	class ProxyDemo
	{
		static void Main(string[] args)
		{
			IBookParser bookParser = new ProxyBookParser(@"../book1.docx");
			System.Console.WriteLine(bookParser.GetNumPages());
		}
	}
}
