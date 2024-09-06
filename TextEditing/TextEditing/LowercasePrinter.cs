public class LowercasePrinter : IPrinter
{
    public void Print(string text)
    {
        Console.WriteLine(text.ToLower());
    }
}