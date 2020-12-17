using NumToWord.Strategy;
using System;

namespace NumToWord
{
    /// <summary>
    /// Used to Convert Number to Word
    /// </summary>
    public class Num2Word
    {

        /// <summary>
        /// Used to Convert Integer Number to Word
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="notation">Indian/Us</param>
        /// <returns>Number Representaion of Word</returns>
        public static string ToWord(int num, WordNotation notation = WordNotation.Indian)
        {
            return GetWord(num.ToString(), notation);
        }

        /// <summary>
        /// Used to Convert Integer Number to Word
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="notation">Indian/Us</param>
        /// <returns>Number Representaion of Word</returns>
        public static string ToWord(long num, WordNotation notation = WordNotation.Indian)
        {
            return GetWord(num.ToString(), notation);
        }

        /// <summary>
        /// Used to Convert Integer Number to Word
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="notation">Indian/Us</param>
        /// <returns>Number Representaion of Word</returns>
        public static string ToWord(byte num, WordNotation notation = WordNotation.Indian)
        {
            return GetWord(num.ToString(),notation);
        }

        /// <summary>
        /// Used to Convert Real Number to Word
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="notation">Indian/Us</param>
        /// <returns>Number Representaion of Word</returns>
        public static string ToWord(double num, WordNotation notation = WordNotation.Indian)
        {
            return GetWord(num.ToString(), notation);
        }

        /// <summary>
        /// Used to Convert Real Number to Word
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="notation">Indian/Us</param>
        /// <returns>Number Representaion of Word</returns>
        public static string ToWord(decimal num, WordNotation notation = WordNotation.Indian)
        {
            return GetWord(num.ToString(), notation);
        }

        private static string GetWord(string number, WordNotation notation)
        {
            StrategyContext strategy = new StrategyContext();
            if (notation == WordNotation.Us)
            {
                strategy.SetNewStrategy(new UsCurrencyStrategy());
            }
            return strategy.GetWord(number);
        }

    }
}
