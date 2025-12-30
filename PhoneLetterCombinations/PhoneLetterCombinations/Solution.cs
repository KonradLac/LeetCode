[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("PhoneLetterCombinationsTests")]

namespace PhoneLetterCombinations
{
    internal class Solution
    {
        /// <summary>
        /// Generates all possible letter combinations that the input digit string could represent on a standard telephone keypad.</summary>
        /// <remarks>Each digit maps to a set of letters as follows: '2' to "abc", '3' to "def", '4' to 
        /// "ghi", '5' to "jkl", '6' to "mno", '7' to "pqrs", '8' to "tuv", and '9' to "wxyz". If the input contains any
        /// character outside the range '2'-'9', the method returns an empty list.</remarks>
        /// <param name="digits">A string containing digits from '2' to '9'. Each digit maps to a set of letters as found on a telephone keypad.</param>
        /// <returns>A list of all possible letter combinations that the input digits could represent. Returns an empty list if 
        /// the input is null, empty, or contains invalid digits.</returns>
        internal static IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return [];
            }
            Dictionary<char, string> phoneMap = new()
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };
            List<string> result = [];
            foreach (char c in digits)
            {
                if (!phoneMap.ContainsKey(c))
                {
                    return [];
                }
            }
            for (int i = 0; i < digits.Length; i++)
            {
                string currentChars = phoneMap[digits[i]];
                if (result.Count == 0)
                {
                    foreach (char c in currentChars)
                    {
                        result.Add(c.ToString());
                    }
                }
                else
                {
                    List<string> tempList = [];
                    foreach (string combination in result)
                    {
                        foreach (char c in currentChars)
                        {
                            tempList.Add(combination + c);
                        }
                    }
                    result = tempList;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL Letter Combinations of a phone number + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Brute force");
            Console.WriteLine("Time complexity: O(n * m), where n is the length of the input digits and m is the average number of letters per digit.");
            Console.WriteLine("Space complexity: O(k), where k is the number of possible combinations.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/letter-combinations-of-a-phone-number/");
            Console.ResetColor();
        }
    }
}
