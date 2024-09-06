public class TextEditor
{
	public string DocumentText { get; private set; } = string.Empty;

	public void AddText(string txt)
	{
		DocumentText += txt;
	}

	public void Print(IPrinter printer)
	{
		printer.Print(DocumentText);
	}
}