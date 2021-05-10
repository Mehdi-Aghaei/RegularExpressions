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
            RegexElement myel = new RegexElement();
            //Console.WriteLine(myel.FindByElementName("Carbon"));
            //Console.WriteLine(myel.CheckDet());



            //Regex re = new Regex(@"a");
            //Regex re = new Regex(@"\S+");
            //Regex re = new Regex(@".+"); every thing and same format
            // we want phone number that just start with 0 or 8
            //Regex re = new Regex(@"[08]\d\d[*-]\d{3}[*-]\d{3,4}");
            // \d{3} exactly 3 digit
            //Regex re = new Regex(@"Mr\.?\s[a-z]\w*");
            // the char before that can have it  or no with using ? exp = https? ==> s is optional also we have optional group  exp= (www\.)?
            // we can create group with ();
            //Regex re = new Regex(@"M(r|s|rs)\.?\s[a-z]\w*");
            // \w* zreo or more word charecter
            // email match
            //Regex re = new Regex(@"[A-Za-z0-9.-]+@[a-zA-Z-]+\.(com|net|edu)");

            // for is not in range we use [^a-z]
            // in the brace we can write a specific charset that we want between pattern
            // we can say range with dash [1-7]number from one to seven
            // its important to know every brace represent 1 charecter [] == one chhar
            //string badString = "Here is a strig with ton of white space.";
            //string CleanedString = Regex.Replace(badString, "\\s+", " ");
            //string[] digits = Regex.Split(Names, @"\D+");
            //Regex re = new Regex(@"https?://(www\.)?(\w+)(\.\w+)");
            //Regex re = new Regex(@"[aeiou]");
            // vowel finder
            // url finder also we have grop 1,2,3 which is $1 $2 $3 
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
