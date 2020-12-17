using NumToWord.Common.english;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord.Strategy
{
    internal class IndiaCurrencyStrategy : CurrencyStrategy
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
                    pos = (numDigit % 4) + 1;
                    place = "Thousand";
                    break;
                case 6:
                case 7:
                    pos = (numDigit % 6) + 1;
                    place = "Lakh";
                    break;
                case 8:
                case 9:
                    pos = (numDigit % 8) + 1;
                    place = "Crore";
                    break;
                case 10:
                case 11:
                    pos = (numDigit % 10) + 1;
                    place = "Arab";
                    break;
                case 12:
                case 13:
                    pos = (numDigit % 12) + 1;
                    place ="Kharab";
                    break;
                case 14:
                case 15:
                    pos = (numDigit % 14) + 1;
                    place ="Nil";
                    break;
                case 16:
                case 17:
                    pos = (numDigit % 16) + 1;
                    place ="Padma";
                    break;
                case 18:
                case 19:
                    pos = (numDigit % 18) + 1;
                    place ="Shankh";
                    break;
                case 20:
                case 21:
                    pos = (numDigit % 20) + 1;
                    place ="MahaShankh";
                    break;
                case 22:
                case 23:
                    pos = (numDigit % 22) + 1;
                    place ="Vranda";
                    break;
                case 24:
                case 25:
                    pos = (numDigit % 24) + 1;
                    place ="MahaVranda";
                    break;
                case 26:
                case 27:
                    pos = (numDigit % 26) + 1;
                    place ="Padma";
                    break;
                case 28:
                case 29:
                    pos = (numDigit % 28) + 1;
                    place ="MahaPadma";
                    break;
                case 30:
                case 31:
                    pos = (numDigit % 30) + 1;
                    place ="Kharva";
                    break;
                case 32:
                case 33:
                    pos = (numDigit % 32) + 1;
                    place ="MahaKharva";
                    break;
                case 34:
                case 35:
                    pos = (numDigit % 10) + 1;
                    place ="Samundra";
                    break;
                case 36:
                    pos = (numDigit % 36) + 1;
                    place ="Ogha";
                    break;
                case 37:
                    pos = (numDigit % 37) + 1;
                    place ="Mahaugha";
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
