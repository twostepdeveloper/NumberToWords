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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount in word");
            string amountWord = Console.ReadLine();
         
            Console.WriteLine("Enter Amount in digit");
            long amoutDigit = Convert.ToInt64(Console.ReadLine());
           // string invoiceWord = "Three Lakh Ninety Eight Thousand Six Hundred Fifty One";
            string result = Num2Word.ToWord(amoutDigit, WordNotation.Indian);

            if (amountWord.ToLower().Equals(result.ToLower()))
            {
                Console.WriteLine("Yes Amount is matched.{0}", result);
            }
            else
            {
                Console.WriteLine("No Amount did not matched.{0}", result);
            }
            Console.ReadKey();

           
        }
    }
}
