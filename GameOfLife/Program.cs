using System;
using System.Threading;
using System.Threading.Channels;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOfLife game = new GameOfLife(25, 100);
            game.Seed();
            

            while (true)
            {
                game.MoveToNextGeneration();
                Console.Clear();
                game.Print();
                Thread.Sleep(50);

            }



        }
    }
}
