using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("StringToIntegerTests")]

namespace StringToInteger
{
    internal class Solution
    {
        internal static int MyAtoi(string s)
        {
            string trimmed = s.Trim();
            if (string.IsNullOrEmpty(trimmed))
            {
                return 0;
            }
            int counter = default;
            bool isNegative = false;
            if (trimmed.ToCharArray()[0] == '-')
            {
                counter++;
                isNegative = true;
            }
            else if (trimmed.ToCharArray()[0] == '+')
            {
                counter++;
                isNegative = false;
            }
            if(trimmed.Length <= counter)
            {
                return 0;
            }
            bool zeroFound = false;
            do
            {
                if (trimmed[counter].Equals("0"))
                {
                    zeroFound = true;
                    counter++;
                }
                else
                {
                    zeroFound = false;
                }
            } while (zeroFound);
            long result = default;
            for (int i = counter; i < trimmed.Length; i++)
            {
                char c = (char)trimmed[i];
                if (!char.IsDigit(c))
                {
                    break;
                }
                result = result * 10 + (c - '0');
                if (!isNegative && result > int.MaxValue)
                {
                    return int.MaxValue;
                }
                if (isNegative && -result < int.MinValue)
                {
                    return int.MinValue;
                }
            }
            return isNegative ? (int)-result : (int)result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode String to Integer + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tries & Errors Approach");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/string-to-integer-atoi/");
            Console.ResetColor();
        }
    }
}
