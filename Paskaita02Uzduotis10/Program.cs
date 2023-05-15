using System;


namespace Paskaita02Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite įvesti skaičių. 
             * Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite skaičių: ");
            int skaičius = Convert.ToInt32(Console.ReadLine());
            
            if (skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius: {0}", skaičius);
                Console.WriteLine("Skaičius pakeltas penktuoju laipsniu {0}", skaičius * skaičius * skaičius * skaičius * skaičius);
            }

            /*Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. 
             * Išveskite abiejų skaičių sumą ir sandaugą.*/

            if (skaičius % 4 != 0)
            {
                Console.WriteLine("Įveskite antrąjį skaičių: ");
                int antrasisSKaičius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skaičiai: {0}, {1}", skaičius, antrasisSKaičius);
                Console.WriteLine("Skaičių suma: '{0}', skaičių sandauga: '{1}'", skaičius + antrasisSKaičius, skaičius * antrasisSKaičius);
            }







        }
    }
}
