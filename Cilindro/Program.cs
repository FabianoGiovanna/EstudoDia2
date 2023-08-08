using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {   
            double volume, superficialArea;
            double pi = Math.PI;

            Console.WriteLine("Welcome to cylinder calculator\n");
            Console.WriteLine("Insert height: ");

            string height = Console.ReadLine();
            double heightConvert = double.Parse(height);

            Console.WriteLine("Insert radius: ");

            string radius = Console.ReadLine();
            double radiusConvert = double.Parse(radius);

            volume = pi * Math.Pow(radiusConvert, 2) * heightConvert;
            superficialArea = 2 * pi * radiusConvert * (radiusConvert + heightConvert);

            Console.WriteLine($"Volume = {volume}     Superficial Area = {superficialArea}" ,volume, superficialArea);



            
        }
    }
}
