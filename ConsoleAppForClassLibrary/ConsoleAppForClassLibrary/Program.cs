using ClassLibrary;

static class Extension
{
    public static void Welcome(this Program2 p)
    {
        Console.WriteLine("My Name is Madhur");
    }
}
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Assignment 1");
        Demo d = new Demo();
        d.Message();

        Console.WriteLine("Assignment 2");
        LengthCounter obj = new LengthCounter();
        String x = Console.ReadLine();
        Console.WriteLine(obj.counter(x));

        Console.WriteLine("Assignment 3");
        Counter counter = new Counter();
        counter.Increment();
        counter.Print();
        counter.Increment();
        counter.Print();
        counter.Decrement();
        counter.Print();

        Console.WriteLine("Assignment 4");
        Program2 p = new Program2();
        p.Greeting();
        p.Welcome();
    }
}