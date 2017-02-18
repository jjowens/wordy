using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComsole
{
    class Program
    {
        static void Main(string[] args)
        {
            testStrings();

            Console.ReadLine();

        }

        static void GetAcrostic()
        {
            string val = " You are no alone.  Mr  Fox will help you as much he can. OK? Thanks for your email. . @@%^&* $% ^";

            string results = Wordy.api.WordSmith.GetAcrostic(val);

            Console.WriteLine(results);
        }

        static void testStrings()
        {
            List<string> lst = new List<string>()
            {
                "BISHOPS pledged on Wednesday evening that the discussion about sexuality would be continued after the General Synod rejected the House of Bishops' proposed way forward on marriage and same-sex relationships.",
                "A tree surgeon and father-of-one died after his chainsaw \"kicked backed\" into his neck, his brother said today. Gregery Bulbuc, 31, died in the tragic accident in Bermondsey, south east London, while trimming a tree in a private back yard.",
                "Air pollution could be contributing to as many as one in 19 deaths in Plymouth, according to figures from Public Health England. Figures suggest 5.4% of deaths of people over 30 in Plymouth may be attributable to fine particulate air pollution, the ..."
            };

            foreach (var s in lst)
            {
                GenericTest(s);
            }

        }

        static void GenericTest(string val)
        {
            Console.WriteLine(val);
            Console.WriteLine("==============================");

            Console.WriteLine("Count Words: {0}", Wordy.api.Counter.CountWords(val));
            Console.WriteLine("Length: {0}", val.Length);
            Console.WriteLine("Count Length No Spaces: {0}", Wordy.api.Counter.GetLengthNoSpaces(val));
            Console.WriteLine("Get Longest: {0}", Wordy.api.WordSmith.GetLongestWord(val));
            Console.WriteLine("Count Vowels: {0}", Wordy.api.Counter.CountVowels(val));
            Console.WriteLine("Count Consonants: {0}", Wordy.api.Counter.CountConsonants(val));
            Console.WriteLine("Count Punctuation: {0}", Wordy.api.Counter.CountPunctuation(val));
            Console.WriteLine("Count UpperCase: {0}", Wordy.api.Counter.CountUpperCase(val));
            Console.WriteLine("Count Lowercase: {0}", Wordy.api.Counter.CountLowerCase(val));
            Console.WriteLine("Count NumericValues: {0}", Wordy.api.Counter.CountNumericValues(val));
            Console.WriteLine("Count Whitespaces: {0}", Wordy.api.Counter.CountWhiteSpaces(val));
            Console.WriteLine("Count Symbols: {0}", Wordy.api.Counter.CountSymbols(val));
            Console.WriteLine("Count Separators: {0}", Wordy.api.Counter.CountSeparators(val));
            Console.WriteLine("Reverse Text: {0}", Wordy.api.WordSmith.ReverseText(val));
            Console.WriteLine("Invert Case: {0}", Wordy.api.WordSmith.InvertCase(val));
            Console.WriteLine("Reverse Words: {0}", Wordy.api.WordSmith.ReverseWords(val));
            Console.WriteLine("Reverse Wording: {0}", Wordy.api.WordSmith.ReverseWording(val));

            Console.WriteLine("");

        }
    }
}
