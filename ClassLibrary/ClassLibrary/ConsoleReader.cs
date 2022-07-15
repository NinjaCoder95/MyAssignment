using static ClassLibrary.Delegates;
using System.Text.RegularExpressions;

namespace ClassLibrary;

public delegate void OneDelegate(string msg);

public class ConsoleReader
{

    public string Run(string s, OneDelegate w, OneDelegate n, OneDelegate j)
    {

        Regex specialChar = new Regex("[^A-Za-z0-9]");
        bool hasSpecialChars = specialChar.IsMatch(s);

        if (!string.IsNullOrEmpty(s))
        {
            int tryInt;
            if (Int32.TryParse(s, out tryInt))
            {
                n("Integer");
                return "Integer";
            }
            else if (hasSpecialChars)
            {
               j("Junk");
                return "Junk";
            }
            else
            {
               w("Word");
                return "Word";
            }

        }
        return "Invalid Input";

    }

}