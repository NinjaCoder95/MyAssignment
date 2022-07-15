namespace ClassLibrary
{
    public class DelegatesAssignment
    {
        
        public static void OnNumber(string msg)
        {
            Console.WriteLine("On Number");
           
        }
        public static void OnWord(string msg)
        {
            Console.WriteLine("On String");
            
        }

        public static void OnJunk(string msg)
        {
            Console.WriteLine("On Junk");
            
        }

    }
}