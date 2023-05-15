using System;


namespace Paskaita02Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suma pirma//

            int a = 4;
            int b = 5;
            int suma = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine();
           
            //suma antra//

            int pirmas = 4;
            int antras = 5;
            int Suma = pirmas + antras;
            Console.WriteLine($"Suma:{pirmas} + {antras} = {pirmas + antras}");
            Console.WriteLine();

            //skirtumas pirmas//

            int skirtumas = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine();

            //skirtumas antras//

            Console.WriteLine($"Skirtumas:{pirmas} - {antras} = {pirmas - antras}");
            Console.WriteLine();

            //daugyba//

            int daugyba = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, daugyba);
            Console.WriteLine();

            //daugyba antra//

            Console.WriteLine($"Daugyba:{pirmas} * {antras} = {pirmas * antras}");
            Console.WriteLine();

            //dalyba pirma//

            double dalyba = (double) a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);
            Console.WriteLine();

            //dalyba antra//

            Console.WriteLine($"Dalyba:{pirmas} / {antras} = { (double) pirmas / antras}");
            Console.WriteLine();

            //Išveskite į ekraną pasirinktą skaičių//
            //jo kvadratą ir jį pakeltą trečiuoju laipsniu//

            //kvadratu pirmas//
                        
            int skaičius = 8;
            int kvadratu = skaičius * skaičius;
            Console.WriteLine("{0}^2 = {1}", skaičius, kvadratu);
            Console.WriteLine();

            // kvadratu antras//

            Console.WriteLine($"Kvadratu: {skaičius}^2 = {skaičius * skaičius}");
            Console.WriteLine();

            //kėlimas trečiuoju laipsniu pirmas//

            int trečiuojuLaipsniu = skaičius * skaičius * skaičius;
            Console.WriteLine("{0}^3 = {1}", skaičius, trečiuojuLaipsniu);
            Console.WriteLine();

            //kėlimas trečiuoju laipsniu antras//

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Trečiuoju laipsniu: {skaičius}^3 = {skaičius * skaičius * skaičius}");
            Console.WriteLine();

            //Išveskite į ekraną trijų skaičių sandaugą//

            int skaičiusA = 2;
            int SkaičiusB = 4;
            int SkaičiusC = 3;
            int sandauga = skaičiusA * SkaičiusB * SkaičiusC;
            Console.WriteLine("{0} * {1} * {2} = {3}", skaičiusA, SkaičiusB, SkaičiusC, sandauga);
            Console.WriteLine();

          
        }
    }
}
