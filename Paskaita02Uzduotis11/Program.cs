using System;

namespace Paskaita02Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
              ar pirmas skaičius didesnis už antrą; 
              ar antras skaičius didesnis už trečią;
              ar trečias skaičius didesnis už pirmą;
              ar pirmi du skaičiai lygūs;

             */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius03 = Convert.ToInt32(Console.ReadLine());

            if (skaičius01 > skaičius02)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (skaičius02 > skaičius03)
            {
                Console.WriteLine("Antras skaičius didesnis už trečią");
            }
            else if (skaičius03 > skaičius01)
            {
                Console.WriteLine("Trečias skaičius didesnis už pirmą skaičių");
            }
            else if (skaičius01 == skaičius02)
            {
                Console.WriteLine("Pirmi du skaičiai yra lygūs");
            }


            /*Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
               ar temperatūra < 0 - išvesti “žiauriai šalta”;
              ar temperatūra < 10 - išvesti “labai šalta”;
               ar temperatūra < 20 - išvesti “šalta”;
              ar temperatūra < 30 - išvesti “normali temperatūra”;
               ar temperatūra < 40 - išvesti “karšta”;
                ar temperatūra >= 40 - išvesti “visiškai degina”; */


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite dienos temperatūrą: ");
            int temperatūra = Convert.ToInt32(Console.ReadLine());
            
            if (temperatūra < 0)
            {
                Console.WriteLine("žiauriai šalta");
            }
            else if (temperatūra < 10)
            {
                Console.WriteLine("labai šalta");
            }
            else if (temperatūra < 20)
            {
                Console.WriteLine("šalta");
            }
            else if (temperatūra < 30)
            {
                Console.WriteLine("normali temperatūra");
            }
            else if (temperatūra < 40)
            {
                Console.WriteLine("karšta");
            }
            else if (temperatūra < 50)
            {
                Console.WriteLine("visiškai degina");
            }

        }
    }
}



