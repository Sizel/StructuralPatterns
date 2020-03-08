namespace Proxy
{
	public interface IBookParser
	{
		int GetNumPages();
		string Path { get; }
	}
}