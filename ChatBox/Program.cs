using System;

namespace ChatBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            bool cicle = true;
            

            while (cicle)
            {
                string response = "help";

                Console.WriteLine("Make a question foolish...");
                question = Console.ReadLine();

                switch(question)
                {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Skynet";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                case "Are you a calculator?":
                    response = "NO!";
                    break;
                case "EXIT":
                    cicle = false;
                    break;
                default:
                    response = "You got me, I'm not that smart!";
                    break;
                }

                Console.WriteLine(response);
            }
            

        }
    }
}
