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
            double term1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second term");
            double term2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third term");
            double term3 = Convert.ToDouble(Console.ReadLine());
            double answear1 = 0;
            double answear2 = 0;

            double step1 = 0;
            double step2 = 0;
            //switch för att prioritera * och / först i uträkningen  sedan uträkning utefter prioritering med hjälp av CheckOpperato
            //första switch satsen är till för att prioritera bort útifall både * och / skulle användas

            bool test = true;

            switch (opperator1)
            {
                case "+":
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
                    break;
                case "-":
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
                    break;
                case "*":
                    step1 = CheckOpperator(term1, term2, opperator1);
                    step2 = CheckOpperator(step1, term3, opperator2);
                    break;
                case "/":
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
        static double addition(double nr1, double nr2)
        {
            double result;
            result = nr1 + nr2;
            return result;
        }

        static double subtraktion(double nr1, double nr2)
        {
            double result;
            result = nr1 - nr2;
            return result;
        }

        static double multiplikation(double nr1, double nr2)
        {
            double result;
            result = nr1 * nr2;
            return result;
        }

        static double division(double nr1, double nr2)
        {
            double result;
            result = nr1 / nr2;
            return result;
        }

        /* CheckOpperator metod för att stega igenom vilken opperator användaren 
         * har valt samt genomföra uträkningen genom att kalla på räkne metoden*/

        static double CheckOpperator(double term1, double term2, string opperator)
        {
            double answear = 0;
            if (opperator == "*")
            {
                double summ1 = (multiplikation(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "+")
            {
                double summ1 = (addition(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "-")
            {
                double summ1 = (subtraktion(term1, term2));
                
                answear = summ1;
            }
            if (opperator == "/")
            {
                double summ1 = (division(term1, term2));
                
                answear = summ1;
            }
            return answear;
        }

    }   
}
