using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.api
{
    public class WordSmithReader
    {

        public enum ReadSwitch
        {
            CountWords,
            CountVowels,
            CountConsonants,
            GetAcrostic,
            LongestWord,
            GetFirstLetterOfEachLine,
        }

        public class Stat
        {
            public string Description { get; set; }
            public int LineNumber { get; set; }
            public string Value { get; set; }
        }

        internal static Dictionary<string, List<Stat>> _dict = new Dictionary<string, List<Stat>>();


        public static IDictionary<string, List<Stat>> ReadFile(string filePath, params ReadSwitch[] readSwitches)
        {
            _dict = new Dictionary<string, List<Stat>>();

            int lineNumber = 1;
            using (var reader = new System.IO.StreamReader(filePath))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        lineNumber += 1;
                        break;
                    }

                    if (string.IsNullOrEmpty(line.Trim()))
                    {
                        lineNumber += 1;
                        continue;
                    }

                    foreach (var readSwitch in readSwitches)
                    {

                        object val = 0;

                        switch (readSwitch)
                        {
                            case ReadSwitch.CountConsonants:
                                val = Counter.CountConsonants(line);
                                break;
                            case ReadSwitch.CountVowels:
                                val = Counter.CountVowels(line);
                                break;
                            case ReadSwitch.CountWords:
                                val = Counter.CountWords(line);
                                break;
                            case ReadSwitch.GetAcrostic:
                                val = WordSmith.GetAcrostic(line);
                                break;
                            case ReadSwitch.LongestWord:
                                val = WordSmith.GetLongestWord(line);
                                break;
                            case ReadSwitch.GetFirstLetterOfEachLine:
                                val = WordSmith.GetFirstLetter(line);
                                break;
                        }

                        Stat s = new Stat();
                        s.Description = readSwitch.ToString();
                        s.Value = val.ToString();
                        s.LineNumber = lineNumber;

                        if (_dict.Keys.Contains(readSwitch.ToString()))
                        {
                            _dict[readSwitch.ToString()].Add(s);
                        }
                        else
                        {
                            List<Stat> stats = new List<Stat>();

                            stats.Add(s);

                            _dict.Add(readSwitch.ToString(), stats);
                        }

                    }

                    lineNumber += 1;
                }

                
            }

            return _dict;
        }




    }
}
