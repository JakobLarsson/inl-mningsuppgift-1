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

            int step1 = 0;
            int step2;
            
            //switch för att prioritera * och / först i uträkningen  sedan uträkning utefter prioritering med hjälp av CheckOpperator

            switch (opperator2)
            {
                
                case "*":
                    step1 = CheckOpperator(term2, term3, opperator2);
                    step2 = CheckOpperator(step1, term1, opperator1);
                    break;
                case "/":
                    step1 = CheckOpperator(term2, term3, opperator2);
                    step2 = CheckOpperator(step1, term1, opperator1);
                    break;
                default:
                    step1 = CheckOpperator(term1, term2, opperator1);
                    step2 = CheckOpperator(step1, term3, opperator2);
                    break;
        
            }
            

            
            
            //opperator 2 ska tilldelas i uträkningen samt svaret ifrån första steget tillsamans med sista termen
            
            
          
            //skriv ut svaret

            Console.WriteLine(term1 + " " + opperator1 + " " + term2 + " " + opperator2 + " " + term3 + " " + step2);
  
            Console.ReadLine();

        }
       
        //metoder för att göra uträkningar med dom olika opperatorerna
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

        /* CheckOpperator metod för att stega igenom vilken opperator användaren 
         * har valt samt genomföra uträkningen genom att kalla på räkne metoden*/

        static int CheckOpperator(int term1, int term2, string opperator)
        {
            int answear = 0;
            if (opperator == "*")
            {
                int summ1 = (multiplikation(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "+")
            {
                int summ1 = (addition(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "-")
            {
                int summ1 = (subtraktion(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "/")
            {
                int summ1 = (division(term1, term2));
                
                answear = summ1;
            }
            return answear;
        }

    }   
}
