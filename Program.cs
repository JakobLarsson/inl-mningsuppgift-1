using System;

namespace Inlamningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //väljer opperatorer och termer
            Console.WriteLine("Enter first opperator: ");
            string opperator1 = Console.ReadLine();

            Console.WriteLine("Enter second opperator: ");
            string opperator2 = Console.ReadLine();

            Console.WriteLine("Enter first term");
            int term1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second term");
            int term2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third term");
            int term3 = Convert.ToInt32(Console.ReadLine());

            // räknar ut första två termerna med addition får välja if sats sedan
            int sum1 = (multiplikation(term1, term2, opperator1));
            Console.WriteLine(sum1);
            

            int sum2 = multiplikation(sum1, term3, opperator2);
            Console.WriteLine(sum2);
            Console.ReadLine();

        }
        static int addition(int nr1, int nr2, string opperator)
        {
            int result;
            result = nr1 + nr2;
            return result;
        }

        static int subtraktion(int nr1, int nr2, string opperator)
        {
            int result;
            result = nr1 - nr2;
            return result;
        }

        static int multiplikation(int nr1, int nr2, string opperator)
        {
            int result;
            result = nr1 * nr2;
            return result;
        }

        static int division(int nr1, int nr2, string opperator)
        {
            int result;
            result = nr1 / nr2;
            return result;
        }

    }   
}
