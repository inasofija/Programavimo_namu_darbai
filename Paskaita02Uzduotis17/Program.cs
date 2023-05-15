using System;


namespace Paskaita02Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti teigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. 
             * Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite teigiamą skaičių: ");
            int skaičius01 = Convert.ToInt32(Console.ReadLine());

            while (skaičius01 > 0)
            {
                Console.WriteLine(skaičius01--);
                    }

            /*Liepkite vartotojui įvesti neigiamą skaičių. 
             * ciklo pagalba šį skaičių išvesti didėjimo tvarka 
             * ki kol jis pasieks 0, taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0.
             * Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite neigiamą skaičių: ");
            int skaičius1 = Convert.ToInt32(Console.ReadLine());

            while (skaičius1 <= 0)
            {
                Console.WriteLine($"{skaičius1++}");
            }


        }
    }
}
