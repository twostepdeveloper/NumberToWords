using NumToWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWorld
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Amount in word");
        //    string amountWord = Console.ReadLine();

        //    Console.WriteLine("Enter Amount in digit");
        //    double amoutDigit = Convert.ToDouble(Console.ReadLine());
        //   // string invoiceWord = "Three Lakh Ninety Eight Thousand Six Hundred Fifty One";
        //   // last commit
        //    string result = Num2Word.ToWord(amoutDigit, WordNotation.Indian);

        //    if (amountWord.ToLower().Equals(result.ToLower()))
        //    {
        //        Console.WriteLine("Yes Amount is matched.{0}", result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Amount did not matched.{0}", result);
        //    }
        //    Console.ReadKey();


        //}

        static void Main(string[] args) // neeraj changes
        {
            Console.WriteLine("Enter Amount in word");
            string amountWord = Console.ReadLine();
            Console.WriteLine("Enter Amount in digit");
            double amoutDigit = Convert.ToDouble(Console.ReadLine());
            // string invoiceWord = "Three Lakh Ninety Eight Thousand Six Hundred Fifty One";
            // last commit
            string result = Num2Word.ToWord(amoutDigit, WordNotation.Indian).Replace("Point", "").Replace("  ", " ");
            string amountWord2 = string.Empty;
            amountWord = amountWord.ToLower().Replace("crores", "crore").Replace("lacks", "lakh").Replace("lack", "lakh")
                .Replace("lakhs", "lakh").Replace("lacs", "lakh").Replace("lac", "lakh").Replace("thousands", "hazaar")
                .Replace("thousand", "hazaar").Replace("and", "").Replace("&", "").Replace("indian", "")
                .Replace("rupees", "").Replace("paise", "").Replace("paisa", "")
                .Replace("hazaar", "thousand").Replace("only", "").ToLower();
            foreach (string splitted in amountWord.Split(' '))
            {
                if (!string.IsNullOrEmpty(splitted))
                {
                    amountWord2 += splitted.ToLower() + " ";
                }
            }
            amountWord2 = amountWord2.TrimEnd();
            if (amountWord2.Equals(result.ToLower()))
            {
                Console.WriteLine("Yes Amount is matched. entered-{0} result-{1}", amountWord2, result);
            }
            else
            {
                Console.WriteLine("No Amount did not matched. entered-{0} result-{1}", amountWord2, result);
            }
            Console.ReadKey();
        }
    }
}
