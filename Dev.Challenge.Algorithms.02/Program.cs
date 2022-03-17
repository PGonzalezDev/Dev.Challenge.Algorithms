using System;

namespace Dev.Challenge.Algorithms._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una contraseña: ");
            string password = Console.ReadLine();
            Console.Clear();

            int i = 0;
            bool successfulPassEntry = false;

            while (i < 3)
            {
                Console.WriteLine("Ingrese nuevamente su contraseña: ");
                string repeatedPassword = Console.ReadLine();

                if (password == repeatedPassword)
                {
                    Console.WriteLine("Felicitaciones, recordás tu contraseña");
                    successfulPassEntry = true;
                    break;
                }

                i++;
            }

            if (!successfulPassEntry)
            {
                Console.WriteLine("Tenes que ejercitar la memoria");
            }

            Console.ReadLine();
        }
    }
}
