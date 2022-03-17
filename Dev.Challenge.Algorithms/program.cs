using System;

namespace Dev.Challenge.Algorithms._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ingrese un numero entero: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            bool isPrimeNumber = true;

            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    isPrimeNumber = false;
                }
            }

            string result;

            if (number != 1 && isPrimeNumber)
            {
                result = " es primo";
            }
            else
            {
                result = " no es primo";
            }

            Console.WriteLine("El numero " + number + result);
        }
    }
}
