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
        Paddle Paddle1;
        Paddle Paddle2;
        Ball ball;

        int width;
        int height;

        

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            ball = new Ball(width / 2, height / 2, 1, 1);

            Paddle1 = new Paddle(2, height / 2, 5);
            Paddle2 = new Paddle(width-3, height / 2, 5);
        }

        public bool Run()
        {
            Console.Clear();
            Paddle1.Draw();
            Paddle2.Draw();
            //Töm hela skärmen i början av varje uppdatering.
            

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                Paddle2.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                Paddle2.Move(-1);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                Paddle1.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                Paddle1.Move(-1);
            }

            ball.Move();
            ball.Draw();
            ball.CheckCollisions(Paddle1, Paddle2, width, height);

            Paddle1.Draw();
            Paddle2.Draw();


            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
