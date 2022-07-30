using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    public class FizzBuzz 
    {
        public FizzBuzz()
        {

        }

        public string FizzBuzzMethod(int number)
        {
            string tmp;
            if (number % 3 == 0 && number % 5 == 0)
            {
                tmp = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                tmp = "Fizz";
            }
            else if (number % 5 == 0)
            {
                tmp = "Buzz";
            }
            else
            {
                tmp = number.ToString();
            }

            return tmp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("FizzBuzz");

            Console.Write("Podaj liczbę: ");
            var fizzBuzz = new FizzBuzz();

            while (true)
            {
                var number = GetNumber();
                var result = fizzBuzz.FizzBuzzMethod(number);
                Console.WriteLine($"Otrzymany wynik: {result}");
                Console.Write("Aby zakończyć program wciśnij 't' lub podaj nową liczbę: ");
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                var value = Console.ReadLine();

                if (value.ToUpper() == "T")
                    Environment.Exit(0);

                if (!int.TryParse(value, out int number))
                {
                    Console.WriteLine("Nieprawidłowe dane, spróbuj jeszcze raz.");
                    continue;
                }

                return number;
            }

        }
    }
}
