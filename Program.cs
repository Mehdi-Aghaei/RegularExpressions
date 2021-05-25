using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;


string file_path = "data.txt";
string Names = await File.ReadAllTextAsync(file_path);










// Very important work with group in regex
// Regex re = new Regex(@"(\d+).\d+,(\d+.\d+),\w,(\d+.\d+)");
// Match m = re.Match(Names);
// List<string> myGrop = new List<string>();
// if(m.Success){
//      for (int i = 1; i <= 3; i++)
//          {
//             Group g = m.Groups[i];
//             string res = g.ToString();
//             myGrop.Add(res);
//            Console.WriteLine("Group"+i+"='" + g + "'");
//         }
// }








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

/*


Character classes
.	any character except newline
\w\d\s	word, digit, whitespace
\W\D\S	not word, digit, whitespace
[abc]	any of a, b, or c
[^abc]	not a, b, or c
[a-g]	character between a & g

Anchors
^abc$	start / end of the string
\b\B	word, not-word boundary

Escaped characters
\.\*\\	escaped special characters
\t\n\r	tab, linefeed, carriage return
Groups & Lookaround
(abc)	capture group
\1	backreference to group #1
(?:abc)	non-capturing group
(?=abc)	positive lookahead
(?!abc)	negative lookahead

Quantifiers & Alternation
a*a+a?	0 or more, 1 or more, 0 or 1
a{5}a{2,}	exactly five, two or more
a{1,3}	between one & three
a+?a{2,}?	match as few as possible
ab|cd	match ab or cd

*/
