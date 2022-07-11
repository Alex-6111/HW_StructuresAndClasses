
using System.Text;
using static System.Console;



namespace HW_StructuresAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Problem1();
         //  Problem2();
        

        Website websiteTest = new Website();
            websiteTest.EnterInfo();
            websiteTest.ExitInfo();

        Journal journal = new Journal();    
            journal.PrintInfo();

        }

        static void PrintSquare(double lenght, double width, string symbol)
        {
            for(int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i >= 1 && i <=lenght-2)&&(j >= 1 && j<= width - 2))
                    {
                        Write(" ");
                    }
                    else
                    {
                        Write(symbol);
                    }
                   
                }
                Write("\n\n");
            }
        }

        static void Problem1()
        {
            Write("Enter lenght -> ");
            double lenght = Convert.ToDouble(ReadLine());
            Write("Enter width -> ");
            double width = Convert.ToDouble(ReadLine());
            Write("Enter symbol -> ");
            string symbol = ReadLine();

            PrintSquare(lenght, width, symbol); 
        }

        static bool IsPalindrom(string? Digit)
        {
            for (int i = 0; i <= Digit.Length / 2; i++)
            {
                if (Digit[i] != Digit[Digit.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Problem2()
        {
            string? Digit = null;
            Write("Enter digit: ");
            Digit = ReadLine();
       
                if (IsPalindrom(Digit))
                {
                    WriteLine("Palindrom!");
                }
                else
                {
                    WriteLine("Not a palindrome!");
                };
        }
    }
}