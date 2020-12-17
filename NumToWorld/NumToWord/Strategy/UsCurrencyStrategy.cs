using NumToWord.Common.english;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord.Strategy
{
    internal class UsCurrencyStrategy : CurrencyStrategy
    {
        protected override string GetPlaceValue(string number, out int pos)
        {
            int numDigit = number.Length;
            string place = string.Empty;
            switch (numDigit)
            {
                case 3:
                    pos = (numDigit % 3) + 1;
                    place = "Hundred";
                    break;
                case 4:
                case 5:
                case 6:
                    pos = (numDigit % 4) + 1;
                    place = "Thousand";
                    break;
                case 7:
                case 8:
                case 9:
                    pos = (numDigit % 7) + 1;
                    place = "Million";
                    break;
                case 10:
                case 11:
                case 12:
                    pos = (numDigit % 10) + 1;
                    place = "Billion";
                    break;
                case 13:
                case 14:
                case 15:
                    pos = (numDigit % 13) + 1;
                    place = "Trillion";
                    break;
                case 16:
                case 17:
                case 18:
                    pos = (numDigit % 16) + 1;
                    place = "Quadrillion";
                    break;
                case 19:
                case 20:
                case 21:
                    pos = (numDigit % 19) + 1;
                    place = "Quintillion";
                    break;

                case 22:
                case 23:
                case 24:
                    pos = (numDigit % 22) + 1;
                    place = "Sextillion";
                    break;
                case 25:
                case 26:
                case 27:
                    pos = (numDigit % 25) + 1;
                    place = "Septillion";
                    break;
                case 28:
                case 29:
                case 30:
                    pos = (numDigit % 28) + 1;
                    place = "Octillion";
                    break;
                case 31:
                case 32:
                case 33:
                    pos = (numDigit % 31) + 1;
                    place = "Nonillion";
                    break;
                case 34:
                case 35:
                case 36:
                    pos = (numDigit % 34) + 1;
                    place = "Decillion";
                    break;
                case 37:
                case 38:
                case 39:
                    pos = (numDigit % 34) + 1;
                    place = "Undecillion";
                    break;
                default:
                    {
                        //isDone = true;
                        throw new Exception("Number is Too Large.");
                    }
            }
            return place;
        }

    }
}
