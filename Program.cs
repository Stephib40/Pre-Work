using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Program
	{
		static void Main()
		{
			do
			{
				Console.WriteLine("Welcome to the Pig Latin Translator!");
				Console.WriteLine("Enter a word to be translated:");
				string input = Console.ReadLine();
				input = input.ToLower();
				char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
				char[] inputArray = input.ToArray();
				char c = input[0];

				string s = "a-zA-Z0-9";  
				var withoutSpecial = new string(s.Where(ch => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)).ToArray());
				//Console.WriteLine("Ooops thats not a letter! Try again? y/n");

				//@"$KUH% I*$)OFNlkfn$" could not get this format to work so tried the a-z;

				//if (s == withoutSpecial)
				//{
				//Console.WriteLine("Ooops thats not a letter! Try again? y/n");
				//}

				//I want to do the pig latin reverse after it checks for special characters. so check for special characters first then run the piglatin 
				//allow punctuation in the input string: ext. exercise
				//dont allow for special characters

				string firstLetter;
				string restWord;
				string pigLatinWord = " ";
				int position;

				firstLetter = input.Substring(0, 1);
				restWord = input.Substring(1, input.Length - 1);
				position = input.IndexOf(firstLetter);

				if (vowel.Contains(c)) //originaly had (position == 1) here and would not run "ay" just "way" 
					{
					pigLatinWord = restWord + firstLetter + "ay";
				}
				else
				{
					pigLatinWord = restWord + "way";
				}

				Console.WriteLine(pigLatinWord);
			}


			while (Continue() == true);


		}
			public static Boolean Continue()
			{
				Boolean run;
				Console.WriteLine("Translate another word?: y/n?");
				string answer = Console.ReadLine();

				if ((answer == "Y") || (answer == "y"))
				{
					run = true;
				}
				else if ((answer == "N") || (answer == "n"))
				{
					run = false;
					Console.WriteLine("aterway."); //original n response was "later" pig latin'd it to "aterway"
				}
				else
				{
					Console.WriteLine("Addaya Addaya"); /*thought it would be funny to change my "yadda yadda" to pig latin for if user inputs not a y or n*/
				run = Continue();
				}
				return run;
			}
		
	}
}


