using System;


namespace Paskaita02Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             * Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5 */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite bet kokį sveiką skaičių: ");
            int skaičius = Convert.ToInt32(Console.ReadLine());
            int daugiklis = 1;
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine($"{skaičius} * {daugiklis} = {skaičius * daugiklis++}");
            Console.WriteLine();

            /* Liepkite vartotojui įvesti tris skaičius. 
             * Į ekraną išveskite šiuos skaičius ir jų vidurkį. */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius03 = Convert.ToInt32(Console.ReadLine());
            int vidurkis = (skaičius01 + skaičius02 + skaičius03) / 3;

            Console.WriteLine("Įvesti skaičiai: {0}, {1}, {2}", skaičius01, skaičius02, skaičius03);
            Console.WriteLine("Skaičių vidurkis: " + vidurkis);
            Console.WriteLine();

            /*Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, jų kvadratus, 
             * juos pakeltus trečiuoju laipsniu, 
             * taip pat tuos skaičius, padalintus iš dviejų */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įvestas skaičius: '{0}, {1}, {2}", skaičius1, skaičius2, skaičius3);
            Console.WriteLine("Šių skaičių kvadratai: '{0}, {1}, {2}'", skaičius1 * skaičius1, skaičius2 * skaičius2, skaičius3 * skaičius3);
            Console.WriteLine("Skaičiai, padalinti iš 2: '{0}, {1}, {2}'", (double) skaičius1 / 2, (double) skaičius2 / 2, (double) skaičius3 / 2);
            Console.WriteLine();
        }
    }
}
