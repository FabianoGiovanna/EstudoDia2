using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {   
            float volume, superficialArea;
            float pi = 3.1415926f;

            Console.WriteLine("Welcome to cylinder calculator\n");
            Console.WriteLine("Insert height: ");
            string height = Console.ReadLine();
            float heightConvert = float.Parse(height);
            Console.WriteLine("Insert radius: ");
            string radius = Console.ReadLine();
            float radiusConvert = float.Parse(radius);

            volume = pi * (radius * radius) * height;
            superficialAreaArea = 2 * pi * radius * (radius + height);

            Console.WriteLine("Volume = {volume}     Superficial Area = {superficialArea}" ,volume, superficialArea);



            
        }
    }
}
