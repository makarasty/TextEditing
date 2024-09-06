public class UppercasePrinter : IPrinter
{
	public void Print(string text)
	{
		Console.WriteLine(text.ToUpper());
	}
}