

namespace NumToWord.Common.romman
{
    class RommanOnes
    {
        public static string GetOnes(int number)
        {
            return GetOnes(number.ToString());
        }

        public static string GetOnes(string number)
        {
            int num = int.Parse(number);
            string word = string.Empty;
            switch (num) {
                case 1:
                    word = "I";
                    break;
                case 2:
                    word = "II";
                    break;
                case 3:
                    word = "III";
                    break;
                case 4:
                    word = "IV";
                    break;
                case 5:
                    word = "V";
                    break;
                case 6:
                    word = "VI";
                    break;
                case 7:
                    word = "VII";
                    break;
                case 8:
                    word = "VIII";
                    break;
                case 9:
                    word = "IX";
                    break;
                case 10:
                    word = "X";
                    break;
                default:
                    {
                        break;
                    }
            }
            return word;
        }
    }
}
