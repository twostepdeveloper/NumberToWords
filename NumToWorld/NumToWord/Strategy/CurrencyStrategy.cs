using NumToWord.Common.english;
using System.Text;

namespace NumToWord.Strategy
{
    internal abstract class CurrencyStrategy : IWordStrategy
    {
        public string GetWord(string number)
        {
            string fword = string.Empty;
            if (number.Contains("."))
            {
                fword = IntegerNumber(number.Substring(0, number.IndexOf("."))) + " Point " + (((number.IndexOf(".") + 1) <= number.Length) ? AfterDecimal(number.Substring(number.IndexOf(".") + 1)) : "");
            }
            else
            {
                fword = IntegerNumber(number);
            }
            return fword;
        }

        protected abstract string GetPlaceValue(string number, out int pos);


        protected string IntegerNumber(string number)
        {
            int numDigit = number.Length;
            int pos = 0;
            string place = string.Empty;
            StringBuilder fword = new StringBuilder();
            if (number.StartsWith("-"))
            {
                fword.Append("Minus");
                number = number.Substring(1);
            }

            while (number.Length > 0)
            {
                if (number.Length == 1)
                {
                    fword.Append(" " + Ones.GetOnes(number));
                    break;
                }
                else if (number.Length == 2)
                {
                    fword.Append(" " + Tens.GetTens(number));
                    break;
                }
                else
                {
                    place = GetPlaceValue(number, out pos);
                }

                if (pos == 1)
                {
                    fword.Append(" " + Ones.GetOnes(number.Substring(0, pos)));
                }
                else if (pos == 2)
                {
                    fword.Append(" " + Tens.GetTens(number.Substring(0, pos)));
                }
                else
                {
                    fword.Append(" " + IntegerNumber(number.Substring(0, pos)));
                }
                fword.Append(" " + place);
                number = number.Substring(pos);
                number = number.TrimStart('0');
            }
            return fword.ToString().Trim();
        }

        protected string AfterDecimal(string number)
        {
            StringBuilder word = new StringBuilder();
            int i = 0;
            while (i < number.Length)
            {
                if (number[i] == '0')
                {
                    word.Append(" Zero");
                    i++;
                    continue;
                }
                word.Append(" " + Ones.GetOnes(number[i].ToString()));
                i++;
            }
            return word.ToString().Trim();
        }
    }
}
