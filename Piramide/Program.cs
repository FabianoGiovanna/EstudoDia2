using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Insert a number...");
            string number = Console.ReadLine();
            int val = int.Parse(number);
            
        for (int i = 0; i < val; i++)
        {
            Console.WriteLine(new String(' ', val-i-1) + new String('*', i+i+1));
        }
            Console.ReadLine();
        }
    }
}
