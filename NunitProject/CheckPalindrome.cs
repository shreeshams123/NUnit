using System;
using System.Linq;


namespace NunitProject
{
    public class CheckPalindrome
    {

        public bool IsPalindrome(string str)
        {
            string res = new string(str.Reverse().ToArray());
                if (str.Equals(res,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            CheckPalindrome p=new CheckPalindrome();
            Console.WriteLine(p.IsPalindrome("madam"));
        }
    }
}
