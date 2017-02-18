using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy
{
    public static class WordyExtensions
    {
        private static List<char> _vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public static bool IsVowel(this char c)
        {
            return _vowels.Contains(c);
        }

        public static bool IsVowel(this string c)
        {
            char temp = new char();
            bool isValid = Char.TryParse(c, out temp);

            if (!isValid) return false;

            return _vowels.Contains(temp);
        }

        public static bool ContainsVowels(this string value)
        {
            //string temp = value.Trim().ToLower();

            //var total = (from c in value where value.ContainsVowels() select c).Count();

            //return (total > 0); ;
            return value.ContainsVowels();
        }


    }
}
