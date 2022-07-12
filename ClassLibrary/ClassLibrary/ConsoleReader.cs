using static ClassLibrary.Delegates;
using System.Text.RegularExpressions;

namespace ClassLibrary;

public delegate string word();
public delegate string number();
public delegate string junk();
public class ConsoleReader
{

    public string Run(string s, word w, number n, junk j)
    {

        Regex specialChar = new Regex("[^A-Za-z0-9]");
        bool hasSpecialChars = specialChar.IsMatch(s);

        if (!string.IsNullOrEmpty(s))
        {
            int tryInt;
            if (Int32.TryParse(s, out tryInt))
            {
                n();
            }
            else if (hasSpecialChars)
            {
               j();
            }
            else
            {
               w();
            }

        }
        return null;

    }

}