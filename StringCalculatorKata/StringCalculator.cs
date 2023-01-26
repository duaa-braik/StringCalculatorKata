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

        private static string CreateNegativesList(string[] Negatives, out string NegativesList)
        {
            NegativesList = "";
            foreach (string negative in Negatives)
            {
                NegativesList += $" {negative},";
            }

            return NegativesList;
        }

        private void CalculateSum(string[] Numbers, out int Sum)
        {
            Sum = 0;
            string[] Negatives = Array.Empty<string>();
            bool HasNegatives = false;

            for (int i = 0; i < Numbers.Length; i++)
            {
                int Number = Parser(Numbers[i]);
                if (Number < 0)
                {
                    HasNegatives = true;
                    Negatives = Negatives.Append(Numbers[i]).ToArray();
                }
                else if (Number <= 1000)
                {
                    Sum += Number;
                }
            }

            if (HasNegatives)
            {
                CreateNegativesList(Negatives, out string NegativesList);
                throw new Exception($"negatives not allowed:{NegativesList}");
            }
        }

        private static string AddNewDelimiter(string Sequence, ref string[] Delimiters)
        {
            string[] SequenceParts = Sequence.Split("\n");
            string NewDelimiter = SequenceParts[0][2..];
            Delimiters = Delimiters.Append(NewDelimiter).ToArray();
            return SequenceParts[1];
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
                Sequence = AddNewDelimiter(Sequence, ref Delimiters);
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
