using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        Paddle Paddle1 = new Paddle();
        Paddle Paddle2 = new Paddle();
        Ball Ball_ = new Ball();

        int width;
        int height;

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            Ball.Instantiate ball;
        }

        public bool Run()
        {
            Paddle1.Draw();
            Paddle2.Draw();
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                Paddle2.Move(5);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                Paddle2.Move(-5);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                Paddle1.Move(5);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                Paddle1.Move(-5);
            }
            


            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
