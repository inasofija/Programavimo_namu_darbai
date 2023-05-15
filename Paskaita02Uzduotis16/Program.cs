using System;


namespace Paskaita02Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Raskite visų skaičių nuo 1 iki 100 sumą*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int suma = 0;
                for (int i=0; i <=100; i++)
            { suma += i;
            }
            Console.WriteLine($"Visų skaičių suma: '{suma}'");
            Console.WriteLine();
            Console.WriteLine();

            /* Raskite visų lyginių skaičių nuo 20 iki 40 sumą.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine($"Lyginių Skaičių nuo 20 iki 40 suma: '{suma}'");
            Console.WriteLine();
            Console.WriteLine();
        }





    }
}

