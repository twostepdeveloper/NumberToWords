
namespace NumToWord.Common.english
{
    internal class Tens
    {
        public static string GetTens(string number)
        {
            return GetTens(int.Parse(number));
        }

        public static string GetTens(int number)
        {
            string name = string.Empty;
            bool isDone;
            name = GetTensMatched(number, out isDone);
            if (!isDone && number > 0)
            {
                name = GetTensMatched(int.Parse(number.ToString().Substring(0, 1) + "0"), out isDone) + " " + Ones.GetOnes(number.ToString().Substring(1));
            }
            return name;
        }

        private static string GetTensMatched(int number, out bool isMatched)
        {
            isMatched = true;
            string name = string.Empty;
            switch (number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    {
                        isMatched = false;
                        break;
                    }
            }
            return name;
        }
    }
}
