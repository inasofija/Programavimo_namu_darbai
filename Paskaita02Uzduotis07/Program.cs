using System;


namespace Paskaita02Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti savo vardą ir amžių. 
             * Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.” */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            int amžius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("jūsų vardas: {0}, o amžius: {1}", vardas, amžius);
            Console.WriteLine();

            /*Liepkite vartotojui įvesti bet kokį skaičių. 
             * Išveskite į ekraną šio skaičiaus kvadratą.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite bet kokį skaičių: ");
            int skaičius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įvestas skaičius: '{0}'", skaičius);
            Console.WriteLine("Šio skaičiaus kvadratas: '{0}'", skaičius * skaičius);
            Console.WriteLine();

            /*Liepkite vartotojui įvesti tris skaičius. Išveskite visų šių skaičių sumą,
             * nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite pirmą skaičių: ");
            int skaičius01= Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaičius02= Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int skaičius03 = Convert.ToInt32(Console.ReadLine());
            int suma = skaičius01 + skaičius02 + skaičius03; 
           
            Console.WriteLine("Įvesti šie skaičiai: '{0}', '{1}' ir '{2}'",skaičius01, skaičius02, skaičius03);
            Console.WriteLine("{0} + {1} + {2} = {3}", skaičius01, skaičius02, skaičius03, suma);
            Console.WriteLine();


        }
    }
}