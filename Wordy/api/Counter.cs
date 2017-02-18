using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.api
{
    public class Counter
    {

        public static int CountVowels(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => x.IsVowel()).Count();

            return total;
        }

        public static int CountConsonants(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => !x.IsVowel()).Count();

            return total;
        }

        public static int CountPunctuation(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsPunctuation(x)).Count();

            return total;
        }

        public static int CountUpperCase(string value)
        {
            int total = 0;

            string temp = value.Trim();

            total = temp.Where(x => Char.IsUpper(x)).Count();

            return total;
        }

        public static int CountLowerCase(string value)
        {
            int total = 0;

            string temp = value.Trim();

            total = temp.Where(x => Char.IsLower(x)).Count();

            return total;
        }

        public static int CountWhiteSpaces(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => Char.IsWhiteSpace(x)).Count();

            return total;
        }

        public static int CountNumericValues(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsNumber(x)).Count();

            return total;
        }

        public static int CountSymbols(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsSymbol(x)).Count();

            return total;
        }

        public static int CountSeparators(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsSeparator(x)).Count();

            return total;
        }

        public static int CountWords(string value)
        {
            int total = 0;

            string[] items = value.Split(' ');

            total = items.Length;

            return total;
        }

        public static int GetLengthNoSpaces(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => !Char.IsWhiteSpace(x)).Count();

            return total;
        }


    }
}
