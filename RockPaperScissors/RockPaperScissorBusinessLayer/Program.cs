using System;

namespace RockPaperScissorBusinessLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BotPlayer testbot = new BotPlayer();
            Console.WriteLine(testbot.GetMove());
        }


    }
}
