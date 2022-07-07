using ClassLibrary;

class Program
{
    public static void Main(String[] args)
    {
        Demo d = new Demo();
        d.Message();
        Console.WriteLine(d.counter("qwertyuiop"));
    }
}