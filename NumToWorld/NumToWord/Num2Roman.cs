using NumToWord.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord
{
    /// <summary>
    /// Used to Convert Number to Roman Number
    /// Limit 1 - 4999
    /// </summary>
    public class Num2Roman
    {
        /// <summary>
        /// Used for converting integer number to Roman Representation
        /// </summary>
        /// <param name="num">Number with limit 1-4999</param>
        /// <returns>Return Roman Representation of Number</returns>
        public static string ToRoman(int num)
        {
            if(num <1 || num > 4999)
            {
                throw new Exception("Number Range must be Between 1-4999");
            }

            StrategyContext strategy = new StrategyContext();
            strategy.SetNewStrategy(new RomanStrategy());
            return strategy.GetWord(num.ToString());
        }
    }
}
