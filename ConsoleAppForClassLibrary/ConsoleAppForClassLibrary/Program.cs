using ClassLibrary;

class Program
{
    public static void Main(String[] args)
    {
        Demo d = new Demo();
        d.Message();
        LengthCounter obj = new LengthCounter();
        String x = Console.ReadLine();
        Console.WriteLine(obj.counter(x));

;
    }
}