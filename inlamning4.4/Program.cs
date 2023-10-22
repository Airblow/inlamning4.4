using System;
namespace inlamning4._4
{
    class Program
    {
        static void Main(string[] args)           
        {
            bool stopProg = false;

            do
            {
                Console.WriteLine("Välj ett av alternativen nedan");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Skriv in 2 tal du vill subtrahera med varandra");
                        string[] numbersSub = Console.ReadLine().Split(" ");
                        int number1Sub = int.Parse(numbersSub[0]);
                        int number2Sub = int.Parse(numbersSub[1]);
                        Console.WriteLine($"{number1Sub} subtraherat med {number2Sub} blir {number1Sub - number2Sub}");
                        Console.WriteLine();

                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Skriv in 2 tal du vill dividera med varandra");
                        string[] numbersDiv = Console.ReadLine().Split(" ");
                        int number1Div = int.Parse(numbersDiv[0]);
                        int number2Div = int.Parse(numbersDiv[1]);
                        Console.WriteLine($"{number1Div} dividerat med {number2Div} blir {(double)number1Div / (double)number2Div}");
                        Console.WriteLine();

                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Programmet avslutades");
                        stopProg = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine($"{answer} är inte ett korrekt svar");
                        Console.WriteLine();
                        break;
                }

            } while (stopProg == false);
            Console.ReadKey();

        }

    }

}
