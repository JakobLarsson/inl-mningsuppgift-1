using System;

namespace Inlamningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, choose two opperators and three terms and i will count aout end result for you");
            Console.WriteLine("Valid opperators: +  -  *  /");
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
            int answear1 = 0;
            int answear2 = 0;

            //opperator 1 ska tilldelas i uträkningen samt term1 och term2

            if (opperator1 == "*") { 
                int summ1 = (multiplikation(term1, term2));
                Console.WriteLine();
                answear1 = summ1;
            }
            if (opperator1 == "+")
            {
                int summ1 = (addition(term1, term2));
                Console.WriteLine();
                answear1 = summ1;
            }
            if (opperator1 == "-")
            {
                int summ1 = (subtraktion(term1, term2));
                Console.WriteLine();
                answear1 = summ1;
            }
            if (opperator1 == "/")
            {
                int summ1 = (division(term1, term2));
                Console.WriteLine();
                answear1 = summ1;
            }
            //opperator2 ska tilldelas till uträkningen samt term 3
            
            if (opperator2 == "*")
            {
                int summ2 = multiplikation(answear1, term3);
                answear2 = summ2;
            }
            if (opperator2 == "+")
            {
                int summ2 = addition(answear1, term3);
                answear2 = summ2;
            }
            if (opperator2 == "-")
            {
                int summ2 = subtraktion(answear1, term3);
                answear2 = summ2;
            }
            if (opperator2 == "/")
            {
                int summ2 = division(answear1, term3);
                answear2 = summ2;
            }


            Console.WriteLine(answear1);
            Console.WriteLine("slutsvar: ", answear2);
            Console.ReadLine();

            
            
            

        }
        static int addition(int nr1, int nr2)
        {
            int result;
            result = nr1 + nr2;
            return result;
        }

        static int subtraktion(int nr1, int nr2)
        {
            int result;
            result = nr1 - nr2;
            return result;
        }

        static int multiplikation(int nr1, int nr2)
        {
            int result;
            result = nr1 * nr2;
            return result;
        }

        static int division(int nr1, int nr2)
        {
            int result;
            result = nr1 / nr2;
            return result;
        }

    }   
}
