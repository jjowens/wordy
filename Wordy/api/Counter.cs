using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.api
{
    public class Counter
    {
        /// <summary>
        /// Count vowels within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountVowels(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => x.IsVowel()).Count();

            return total;
        }

        /// <summary>
        /// Count consonants within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountConsonants(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => !x.IsVowel()).Count();

            return total;
        }

        /// <summary>
        /// Count punctations within string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountPunctuation(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsPunctuation(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all characters in upper case within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountUpperCase(string value)
        {
            int total = 0;

            string temp = value.Trim();

            total = temp.Where(x => Char.IsUpper(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all characters in lower case within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountLowerCase(string value)
        {
            int total = 0;

            string temp = value.Trim();

            total = temp.Where(x => Char.IsLower(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all whitespaces within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountWhiteSpaces(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => Char.IsWhiteSpace(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all characters that is a numeric value within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountNumericValues(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsNumber(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all symbols within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountSymbols(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsSymbol(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all separators within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountSeparators(string value)
        {
            int total = 0;

            string temp = value.ToLower().Trim();

            total = temp.Where(x => Char.IsSeparator(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all words within string. It will spilt string by whitespace.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountWords(string value)
        {
            int total = 0;

            string[] items = value.Split(' ');

            total = items.Length;

            return total;
        }

        /// <summary>
        /// Count all characters within string, while ignoring whitespaces 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetLengthNoSpaces(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => !Char.IsWhiteSpace(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all characters within string, while ignoring whitespaces, punctations or any other special characters. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountLetters(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => Char.IsLetter(x)).Count();

            return total;
        }

        /// <summary>
        /// Count all digit characters within string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CountDigits(string value)
        {
            int total = 0;

            string temp = value;

            total = temp.Where(x => Char.IsDigit(x)).Count();

            return total;
        }


    }
}
