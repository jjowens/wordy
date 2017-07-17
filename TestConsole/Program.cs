using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordy;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //testStrings();
            //testVowels();
            testWordSmithReader();
            //RemoveVowels();

            Console.WriteLine("Completed...");
            Console.ReadLine();


        }

        static void GetAcrostic()
        {
            string val = " Itsy Bitsy spider climbing up the spout, Down came the rain and washed the spider out, Out came the sun and dried up all the rain, Now Itsy Bitsy spider went up the spout again! ";

            string results = Wordy.api.WordSmith.GetAcrostic(val);

            Console.WriteLine(results);
        }

        static void testVowels()
        {
            List<string> items = new List<string>()
            {
                "a", "b", "c", "d", "e", "i", "o", "u"
            };

            foreach (var s in items)
            {
                Console.WriteLine("{0} {1} a vowel", s, (s.IsVowel()) ? "is" : "is not");
            }

            items = new List<string>()
            {
                "Flyby",
                "Apples",
                "Station",
                "Sky"
            };

            foreach (var s in items)
            {
                Console.WriteLine("{0} {1} contain a vowel", s, (s.ContainsVowels()) ? "does" : "does not");
            }

            Console.WriteLine("");
        }

        static void testStrings()
        {
            List<string> lst = new List<string>()
            {
                "Flyby",
                "A fox jumped high",
                "Humpty Dumpty sat on a wall,Humpty Dumpty had a great fall. All the King's horses, And all the King's men Couldn't put Humpty together again!",
                "Itsy Bitsy spider climbing up the spout, Down came the rain and washed the spider out, Out came the sun and dried up all the rain, Now Itsy Bitsy spider went up the spout again!",
                "Red sky at night, Sailor's delight; Red sky at morning, Sailor's warning."
            };

            foreach (var s in lst)
            {
                GenericTest(s);
            }

            Console.WriteLine("");
        }

        static void GenericTest(string val)
        {
            Console.WriteLine(val);
            Console.WriteLine("==============================");

            Console.WriteLine("Count Words: {0}", Wordy.api.Counter.CountWords(val));
            Console.WriteLine("Contains Vowels: {0}", Wordy.api.WordSmith.ContainsVowels(val));
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
            Console.WriteLine("Invert Case: {0}", Wordy.api.WordSmith.InvertCase(val));
            Console.WriteLine("Reverse Text: {0}", Wordy.api.WordSmith.ReverseText(val));
            Console.WriteLine("Reverse Words: {0}", Wordy.api.WordSmith.ReverseWords(val));
            Console.WriteLine("Reverse Wording: {0}", Wordy.api.WordSmith.ReverseWording(val));
            Console.WriteLine("Get Top Longest: {0}", Wordy.api.WordSmith.GetTopLongestWords(val, 3));
            Console.WriteLine("Find Most Repeated Words: {0}", Wordy.api.WordSmith.FindRepeatedWords(val));

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict = Wordy.api.WordSmith.FindRepeatedWordsWithCount(val);

            Console.WriteLine("Find Most Repeated Words with count:");

            foreach(var item in dict)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

            Console.WriteLine("");

        }

        static void testWordSmithReader()
        {

            string[] files = System.IO.Directory.GetFiles(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rhymes"), "*.*");

            foreach (var filePath in files)
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);

                Console.WriteLine(fileName);
                Console.WriteLine("==================");

                var results = Wordy.api.WordSmithReader.ReadFile(filePath,
                Wordy.api.WordSmithReader.ReadSwitch.LongestWord,
                Wordy.api.WordSmithReader.ReadSwitch.GetFirstLetterOfEachLine, 
                Wordy.api.WordSmithReader.ReadSwitch.RemoveVowels);

                foreach (var r in results)
                {
                    Console.WriteLine("{0}", r.Key);

                    foreach (var item in r.Value)
                    {
                        Console.WriteLine("Line {0}: {1}", item.LineNumber, item.Value);
                    }
                }

            };

            
        }

        static void RemoveVowels()
        {
            List<string> lst = new List<string>()
            {
                "Flyby",
                "A fox jumped high",
                "Humpty Dumpty sat on a wall,Humpty Dumpty had a great fall. All the King's horses, And all the King's men Couldn't put Humpty together again!",
                "Itsy Bitsy spider climbing up the spout, Down came the rain and washed the spider out, Out came the sun and dried up all the rain, Now Itsy Bitsy spider went up the spout again!",
                "Red sky at night, Sailor's delight; Red sky at morning, Sailor's warning."
            };

            foreach (var s in lst)
            {
                Console.WriteLine("Remove Vowels");
                Console.WriteLine(Wordy.api.WordSmith.RemoveVowels(s));
                Console.WriteLine("");
                Console.WriteLine("Remove Consonants");
                Console.WriteLine(Wordy.api.WordSmith.RemoveConsonants(s));
            }

        }
    }
}
