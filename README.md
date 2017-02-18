# Wordy
A .Net library that reads and analyse your text strings like reversing text, count the number of vowels or punctations. It does other stuff, too. The most useless library I ever created.

The library offers two APIs; WordSmith and Counter.

# Wordsmith
Wordsmith is an api where it accepts a string based value and manuiplates the strings such as reversing words one by one or reversing the whole text. It also can be used to check if the text contains any vowels or consonants.

The following functions are available.

* WordSmith.ContainsVowels(value));
* WordSmith.GetLongestWord(value));
* WordSmith.GetTopLongestWords(val, (optional) max = 1)
* WordSmith.InvertCase(value));
* WordSmith.ReverseText(value));
* WordSmith.ReverseWords(value));
* WordSmith.ReverseWording(value));
* WordSmith.FindRepeatedWords(val)

# Counter
Counter counts stuff within a string value like counting the number of characters with no spaces, counting the number of vowels, counting the number of lower/upper case characters.

The following functions are available.

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

# Extensions
The library has a special extension where you can check if a string value is a vowel or contains any vowels.

Just add "using Wordy;" at the head of your code file (if using CSharp).

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


