using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace frequencycode
{
    class Program
    {
        static void Main(string[] args)
        {   
			List<string> list = new List<string>();
			using (StreamReader reader = new StreamReader(args[0]))
			{
				//reads the file
				string lines= reader.ReadToEnd();
				//removes white space - tab, new line,etc
						string lineWithoutWhiteSpace = Regex.Replace(lines, @"\s+", "");
				       //adds to a list
						list.Add(lineWithoutWhiteSpace);
						Console.WriteLine("Text file: " + lines);
						Console.WriteLine("Text file without white space: " + lineWithoutWhiteSpace);
						Console.WriteLine("Total characters: " + lineWithoutWhiteSpace.Length);
				         
				//array with characters
						char[] charArray = { 'a', 'A', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
						var characterList = new List<Tuple<int, char>>();
						var tenCharactersList = new List<Tuple<int, char>>();
						
						foreach (char c in charArray)
						{
					        // count the char without the whitespace
							int count = lineWithoutWhiteSpace.Count(f => f == c);

					        //add to characterlist array
							characterList.Add(new Tuple<int, char>(count, c));

						}

						//sorts the list
						characterList.Sort();
						characterList.Reverse();

						//gets the first ten characters 
						tenCharactersList = characterList.GetRange(0, 10);
						tenCharactersList.ForEach(Console.WriteLine);

						Console.WriteLine("Press any key to exit the console.");
						System.Console.ReadKey();
					
			}
		}
	}

}

