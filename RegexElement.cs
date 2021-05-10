using System;
using System.IO;
using System.Text.RegularExpressions;
namespace RegularExp
{
    class RegexElement
    {
        public string AtomicNumber { get; set; }
        public string ElementName { get; set; }
        public string Symbol { get; set; }

        public string AtomicMass { get; set; }
        /*AtomicMass NumberofNeutrons    NumberofProtons NumberofElectrons   Period Group   Phase Radioactive Natural Metal   Nonmetal Metalloid   Type AtomicRadius    Electronegativity FirstIonization Density MeltingPoint    BoilingPoint NumberOfIsotopes    Discoverer Year    SpecificHeat NumberofShells  NumberofValence*/
        public string FindByElementName(string elementName)
        {
            ElementName = elementName;
            string pattern = string.Format(@"\d\d?\d?,{0}+,\w+,\d+\.\d+,\d+,\d+,\d+,\d+,\d+,\w+", elementName);
            string elements_path = @"G:\Programming\CSharpPrograms\C#ConsoleProjects\RegularExp\Elements.csv";
            string elements = File.ReadAllText(elements_path);
            Regex re = new Regex(pattern);
            MatchCollection matchedNames = re.Matches(elements);
            int a;
            a = matchedNames.Count;
            if (a > 0)
            {
                foreach (var item in matchedNames)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                return "couldn't find any match";
            }
            return "done";

        }
    }
}