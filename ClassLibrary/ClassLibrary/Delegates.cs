namespace ClassLibrary
{
    public class Delegates
    {

        public static string OnNumber()
        {
            Console.WriteLine("On Number");
            return "Integer";
        }
        public static string OnWord()
        {
            Console.WriteLine("On String");
            return "String";
        }

        public static string OnJunk()
        {
            Console.WriteLine("On Junk");
            return "Special Character";
        }

    }
}