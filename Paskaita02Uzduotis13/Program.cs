using System;


namespace Paskaita02Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
             * ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             * ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą. */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius03 = Convert.ToInt32(Console.ReadLine());

            switch (skaičius01)
            {
                case 1:
                    Console.WriteLine("Pirmas skaičius lygus 1");
                    Console.WriteLine("Visų skaičių suma: '{0}'", skaičius01 + skaičius02 + skaičius03);
                    break;
                case 2:
                    Console.WriteLine("Pirmas skaičius lygus 2");
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: '{0}'", skaičius01 - skaičius03);
                    break;
                case 3:
                    Console.WriteLine("Pirmas skaičius lygus 3");
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: '{0}'", skaičius02 * skaičius03);
                    break;


            }

        }
    }
}
