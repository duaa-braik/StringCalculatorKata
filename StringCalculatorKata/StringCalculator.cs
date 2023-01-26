using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private int Parser(string s)
        {
            return int.Parse(s);
        }

        private void CalculateSum(string[] Numbers, out int Sum)
        {
            Sum = 0;
            for(int i = 0; i < Numbers.Length; i++)
            {
                Sum += Parser(Numbers[i]);
            }
        }

        private static void AddNewDelimiter(ref string Sequence, ref string[] Delimiters)
        {
            string[] StringParts = Sequence.Split("\n");
            string NewDelimiter = StringParts[0][2..];
            Delimiters = Delimiters.Append(NewDelimiter).ToArray();
            Sequence = StringParts[1];
        }

        public int Add(string Sequence)
        {
            if(string.IsNullOrEmpty(Sequence) || string.IsNullOrWhiteSpace(Sequence))
            {
                return 0;
            }

            string[] Delimiters = { ",", "\n" };
            string[] Numbers;

            if (Sequence.StartsWith("//"))
            {
                AddNewDelimiter(ref Sequence, ref Delimiters);
            }

            Numbers = Sequence.Split(Delimiters, StringSplitOptions.None);

            if (Numbers.Length == 1)
            {
                return Parser(Numbers[0]);
            } 
            else
            {
                CalculateSum(Numbers, out int Sum);
                return Sum;
            }
        }
    }
}
