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
                return Parser(Numbers[0]) + Parser(Numbers[1]);
            }
        }
    }
}
