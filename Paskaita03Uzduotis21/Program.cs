using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita03Uzduotis21
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            /* Susikurti 2 masyvus su duomenimis, 
             * išbandant abu kūrimo būdus 
             * (iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
             * pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
             * skirtą studentų pažymiams saugoti;
             * skirtą mašinų markėms saugoti. */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int [] pažymiai = {9, 10, 5, 8, 4, 8, 6, 7};

            string[] autoMarkės = new string [6];
            autoMarkės[0] = "Toyota";
            autoMarkės[1] = "Ford";
            autoMarkės[2] = "Hyunday";
            autoMarkės[3] = "Volkswagen";
            autoMarkės[4] = "Porsche";
            autoMarkės[5] = "Kia";

            Console.WriteLine(pažymiai[3]);
            Console.WriteLine(pažymiai[6]);
            Console.WriteLine(pažymiai.Length);
            Console.WriteLine(pažymiai.First());
            Console.WriteLine(pažymiai.Last());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(autoMarkės[3]);
            Console.WriteLine(autoMarkės.Length);
            Console.WriteLine(autoMarkės.Last());
            Console.WriteLine(autoMarkės.First());
            Console.WriteLine(autoMarkės.Length-1);
            Console.WriteLine(autoMarkės.Length+1);

            Console.WriteLine();

            int[] skaičiai = new int[5];
            for (int i = 0; i < 5; i++);

            { 
                Console.Write("Įveskite skaičių: ");
                skaičiai[i] = Convert.ToInt32(Console.ReadLine());
            
            }







        }
    }
}
