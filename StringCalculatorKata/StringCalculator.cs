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

        public int Add(string NumbersString)
        {
            if(string.IsNullOrEmpty(NumbersString) || string.IsNullOrWhiteSpace(NumbersString))
            {
                return 0;
            }

            string[] Numbers = NumbersString.Split(",");

            if(Numbers.Length == 1)
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
