# Wordy
A .Net library that reads and analyse your text strings like reversing text, count the number of vowels or punctations. I created this library for fun.

The library offers a few APIs; WordSmith, Counter and WordSmithReader.

# Wordsmith
Wordsmith is an api where it accepts a string based value and manipulates the strings such as reversing words one by one or reversing the whole text. It also can be used to check if the text contains any vowels or consonants.

The following functions are available. Not an exhaustive list

* Wordsmith.GetAcrostic(value);
* WordSmith.ContainsVowels(value));
* WordSmith.GetLongestWord(value));
* WordSmith.GetTopLongestWords(val, (optional) max = 1)
* WordSmith.InvertCase(value));
* WordSmith.ReverseText(value));
* WordSmith.ReverseWords(value));
* WordSmith.ReverseWording(value));
* WordSmith.FindRepeatedWords(val)
* WordSmith.RemoveVowels(val)
* WordSmith.RemoveConsonants(val)

# Counter
Counter does sum calculations on a string value like counting white spaces, vowels or lower/upper case characters.

The following functions are available.Not an exhaustive list

* Counter.CountWords(value));
* Counter.GetLengthNoSpaces(value));
* Counter.CountVowels(value));
* Counter.CountConsonants(value));
* Counter.CountPunctuation(value));
* Counter.CountUpperCase(value));
* Counter.CountLowerCase(value));
* Counter.CountNumericvalueues(value));
* Counter.CountWhiteSpaces(value));
* Counter.CountSymbols(value));
* Counter.CountSeparators(value));

# WordSmithReader
WordSmithReader is an api where it accepts a file path as a string along with switches. It will return a Dictionary with a string based Key name and a List of Stat objects.

This api may be useful for reading text based files e.g. *.csv, *.txt.

The following switches are available. Not an exhaustive list.

* CountWords
* CountVowels
* CountConsonants
* GetAcrostic
* LongestWord
* GetFirstLetterOfEachLine

Example
```C#
using System;
using System.Collections.Generic;
using Wordy;

static void testWordSmithReader()
{

	string filePath = "C:\\lab\\HumptyDumpty.txt";

	string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);

	Console.WriteLine(fileName);
	Console.WriteLine("==================");

	var results = Wordy.api.WordSmithReader.ReadFile(filePath,
	Wordy.api.WordSmithReader.ReadSwitch.LongestWord,
	Wordy.api.WordSmithReader.ReadSwitch.GetFirstLetterOfEachLine);

	foreach (var r in results)
	{
		Console.WriteLine("{0}", r.Key);

		foreach (var item in r.Value)
		{
			Console.WriteLine("Line {0}: {1}", item.LineNumber, item.Value);
		}
	}

}

```


# Extensions
The library has a special extension where you can check if a string value is a vowel or contains any vowels, without having to use the WordSmith api directly. 

When you add "using Wordy;" to the head of your code, all string based values will automatically have a IsVowel/ContainsVowels extensions. 

The following extensions are available
* IsVowel();
* ContainsVowels();
* ContainsConsonants();

Example

```C#
using System;
using System.Collections.Generic;
using Wordy;

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
		Console.WriteLine("{0} {1} contain a vowel", 
		s, 
		(s.ContainsVowels()) ? "does" : "does not");
	}

}
```


