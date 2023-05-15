using System;


namespace Paskaita02Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite įvesti tris skirtingus skaičius. 
             * Suraskite, kuris iš šių skaičių yra didžiausias.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius03 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Skaičiai: '{0}', '{1}', '{2}'", skaičius01, skaičius02, skaičius03);
           
            if (skaičius01 > skaičius02 && skaičius01 > skaičius03)
            {
                Console.WriteLine("Skaičius {0} yra didžiausias", skaičius01);
            }
            else if (skaičius02 > skaičius01 && skaičius02 > skaičius03)
            {
                Console.WriteLine("Skaičius {0} yra didžiausias", skaičius02);
            }
             else if (skaičius03 > skaičius01 && skaičius03 > skaičius02)
            {
                Console.WriteLine("Skaičius {0} yra didžiausias", skaičius03);
            }

            /*Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             * ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             * ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             *  ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius2 = Convert.ToInt32(Console.ReadLine());


            if (skaičius1 > skaičius2 || skaičius1 == 0)
            {
                Console.WriteLine("pirmas teiginys teisingas");
            }

            else if (skaičius2 > skaičius1 || skaičius2 == 5)
            {
                Console.WriteLine("antras teiginys teisingas");

            }
            else if (skaičius1 > skaičius2 && skaičius1 == 20)

            {
                Console.WriteLine("trečias teiginys teisingas");

            }

            else if (skaičius2 > skaičius1 && skaičius2 < 100)
            {
                Console.WriteLine("ketvirtas teiginys teisingas");
            }
        }
    }
}
