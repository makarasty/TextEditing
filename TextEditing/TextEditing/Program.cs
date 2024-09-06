public class Program
{
	public static void Main()
	{
		TextEditor editor = new TextEditor();

		editor.AddText("Привіт світе я крута программа ");
		editor.AddText("Мене написали круті кодери не індуси ");
		editor.AddText("Чесно ");

		IPrinter upperPrinter = new UppercasePrinter();
		editor.Print(upperPrinter);

		IPrinter lowerPrinter = new LowercasePrinter();
		editor.Print(lowerPrinter);
	}
}
