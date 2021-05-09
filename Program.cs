using System;
using System.Text.RegularExpressions;
using System.IO;
namespace RegularExp
{
    class Program
    {

        static void Main(string[] args)
        {
            //string path = Directory.GetCurrentDirectory();
            string file_path = @"G:\Programming\CSharpPrograms\C#ConsoleProjects\RegularExp\data.txt";
            string Names = File.ReadAllText(file_path);

            //Regex re = new Regex(@"\S+");
            //Regex re = new Regex(@".+"); every thinh and same format
            //Regex re = new Regex(@"[08]\d\d[*-]\d{3}[*-]\d{3,4}");
            // \d{3} exactly 3 digit
            //Regex re = new Regex(@"[E]ri.+");
            //Regex re = new Regex(@"Mr\.?\s[a-z]\w*");
            // it can have that or no with ?
            // we can create group with ();
            Regex re = new Regex(@"M(r|s|rs)\.?\s[a-z]\w*");
            // \w* zreo or more word charecter
            // + will fix formating, I guess.

            // we want phone number that just start with 0 or 8
            // for is not in range we use [^a-z]
            // in the brace we can write a specific charset that we want between pattern
            // we can say range with dash [1-7]number from one to seven
            // its important to know every brace represent 1 charecter [] == one chhar
            // + sign for word by word not char by char
            string badString = "Here is a strig with ton of white space.";
            string CleanedString = Regex.Replace(badString, "\\s+", " ");
            string[] digits = Regex.Split(Names, @"\D+");
            MatchCollection matchedNames = re.Matches(Names);

            foreach (var item in matchedNames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
/*
 * Guid
.       - Any Character Except New Line
\d      - Digit (0-9)
\D      - Not a Digit (0-9)
\w      - Word Character (a-z, A-Z, 0-9, _)
\W      - Not a Word Character
\s      - Whitespace (space, tab, newline)
\S      - Not Whitespace (space, tab, newline)

\b      - Word Boundary
\B      - Not a Word Boundary
^       - Beginning of a String
$       - End of a String

[]      - Matches Characters in brackets
[^ ]    - Matches Characters NOT in brackets
|       - Either Or
( )     - Group

Quantifiers:
*       - 0 or More
+       - 1 or More
?       - 0 or One
{3}     - Exact Number
{3,4}   - Range of Numbers (Minimum, Maximum)


#### Sample Regexs ####

[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+*/
