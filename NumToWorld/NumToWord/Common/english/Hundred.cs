using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord.Common.english
{
    internal class Hundred
    {

        public static string GetHundred(string number)
        {
            return GetHundred(int.Parse(number));
        }

        public static string GetHundred(int number)
        {
            string name = string.Empty;
            //bool isDone;
            //name = GetTensMatched(number, out isDone);
            //if (!isDone && number > 0)
            //{
            //    name = GetTensMatched(int.Parse(number.ToString().Substring(0, 1) + "0"), out isDone) + " " + Ones.GetOnes(number.ToString().Substring(1));
            //}
            //return Ones.GetOnes();
            return "";
        }
    }
}
