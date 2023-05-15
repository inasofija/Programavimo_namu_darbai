using System;


namespace Paskaita02Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, 
             * tuomet į ekraną išveskite, kad “jūs galite balsuoti”.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Įveskite savo amžių: ");
            int amžius = Convert.ToInt32(Console.ReadLine());
            if (amžius >= 18)
                Console.WriteLine("Jūs galite balsuoti");

            /*Liepkite vartotojui įvesti bet kokį skaičių. 
             * Parašykite šias atskiras if sąlygas:
              Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją :) */

            Console.Write("Įveskite bet kokį skaičių: ");
            int skaičius = Convert.ToInt32(Console.ReadLine());

            if (skaičius < 0)
            {
                Console.WriteLine("Rėkiu ant Jūsų");
            }

            /*Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją; */

            if (skaičius >= 0)
            {
                Console.WriteLine("Sveikinu !!!");
            }

            /*Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;*/

            if (skaičius % 2 == 0)
            {
                Console.WriteLine("Taip, skaičius yra lyginis");
           
            }
            /*Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”; */

            if (skaičius % 4 == 0)
            {
                Console.WriteLine("Taip, dalinasi iš 4");

            }

            /*Patikrinti, ar skaičius yra didesnis nei 10, 
             * jei taip - išvesti “taip, skaičius yra didesnis už 10” */

            if (skaičius > 10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10");

            }

            /* Liepkite vartotojui įvesti du savo pažymius, 
             * raskite šių pažymių vidurkį, patikrinkite, 
             * ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.*/
            Console.Write("Įveskite pirmąjį pažymį: ");
            int pirmasisPažymys = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrąjį pažymį: ");
            int antrasisPažymys = Convert.ToInt32(Console.ReadLine());

            if (pirmasisPažymys + antrasisPažymys / 2 >= 5)
            
            {
                Console.WriteLine("Valio!!!");

            }


        }

    }
}
