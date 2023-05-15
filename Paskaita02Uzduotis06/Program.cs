using System;
using System.Data;

namespace Paskaita02Unduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //išveskite pasirinkto skaičiaus daugybos lentelę//

            int skaičius = 4;
            int daugiklis = 0;
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine();

            /*Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. 
             * Išveskite į ekraną šio skaičiaus skaitmenų sandaugą. */

            int DvizenklisSkaicius = 42;
            int desimtys = DvizenklisSkaicius / 10;
            int vienetai = DvizenklisSkaicius % 10;
            Console.WriteLine($"Dvizenklis skaicius: {DvizenklisSkaicius}");
            Console.WriteLine($"Skaitmenu sandauga: {desimtys} * {vienetai} = {desimtys * vienetai}");
            Console.WriteLine();

              }
    }
}
