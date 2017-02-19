using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wordy.api
{
    public class WordSmith
    {
        private static List<char> _vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        /// <summary>
        /// Get first letters of each word.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string GetAcrostic(string val)
        {
            StringBuilder sb = new StringBuilder();
            List<string> split = new List<string>()
            {
                " "
            };

            var items = val.Split(split.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in items)
            {
                string firstLetter = item[0].ToString();

                bool IsLetter = Regex.IsMatch(firstLetter, "[a-z]", RegexOptions.IgnoreCase);

                if (!IsLetter) continue;

                sb.AppendFormat("{0}", firstLetter);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Reverses string value e.g. ABC > CBA
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ReverseText(string value)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var s in value)
            {
                sb.Insert(0, s);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Inverts case sensitvity of character in string e.g. Apple > aPPLE
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string InvertCase(string value)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var s in value)
            {
                if (Char.IsLower(s))
                {
                    sb.AppendFormat("{0}", s.ToString().ToUpper());
                }
                else if (Char.IsUpper(s))
                {
                    sb.AppendFormat("{0}", s.ToString().ToLower());
                }
                else
                {
                    sb.Append(s);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// It reverses each word in a string without reversing the whole text e.g. A fox jumped high > hgih depmuj xof A 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ReverseWords(string value)
        {
            StringBuilder sb = new StringBuilder();

            string[] items = value.Split(' ');

            foreach (var item in items)
            {
                StringBuilder temp = new StringBuilder();

                foreach (var s in item)
                {
                    temp.Insert(0, s);
                }

                sb.AppendFormat("{0} ", temp.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the longest word from string. It checks the length of each word in string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetLongestWord(string value)
        {
            string temp = string.Empty;

            List<string> items = value.Split(' ').ToList();

            temp = items.OrderByDescending(x => x.Length).FirstOrDefault();

            return temp;
        }

        /// <summary>
        /// Gets the top nth longest words from string. It checks the length of each word in string and returns a number of words. Default max is 1.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static string GetTopLongestWords(string value, int max=1)
        {
            string temp = string.Empty;

            if (max == 0) max = 1;

            List<string> items = value.Split(' ').ToList();

            var results = items.OrderByDescending(x => x.Length).Take(max).ToList();

            temp = string.Join(", ", results);

            return temp;
        }

        /// <summary>
        /// The string value will be read from end to beginning e.g. A fox jumped high > high jumped fox A 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ReverseWording(string value)
        {
            string temp = string.Empty;

            temp = ReverseWords(value);
            temp = ReverseText(temp);

            return temp;
        }

        /// <summary>
        /// Find all words in string that are repeated more than once.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FindRepeatedWords(string value)
        {
            List<string> items = value.Split(' ').ToList();
            List<string> temp = new List<string>();

            foreach (var item in items)
            {
                int total = items.Where(x => x.ToLower() == item.ToLower()).Count();

                if (total > 1)
                {
                    if (!temp.Contains(item))
                    {
                        temp.Add(item);
                    }

                }
            }

            string results = string.Join(",", temp.ToArray());

            return results;
        }

        public static Dictionary<string, int> FindRepeatedWordsWithCount(string value)
        {
            List<string> items = value.Split(' ').ToList();
            List<string> temp = new List<string>();
            Dictionary<string, int> results = new Dictionary<string, int>();

            foreach (var item in items)
            {
                if (results.ContainsKey(item)) continue;

                int total = items.Where(x => x.ToLower() == item.ToLower()).Count();

                if (total > 1)
                {
                    if (!results.ContainsKey(item))
                    {
                        results.Add(item, total);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Checks if string contains Vowels
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContainsVowels(string value)
        {
            string temp = value.Trim().ToLower();

            return (Counter.CountVowels(temp) > 0); ;
        }

        /// <summary>
        /// Checks if string contains Consonants
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContainsConsonants(string value)
        {
            string temp = value.Trim().ToLower();

            return (Counter.CountConsonants(temp) > 0); ;
        }


    }
}
