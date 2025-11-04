using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Labb2_ConsolePong;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        Paddle Paddle1;
        Paddle Paddle2;
        public Ball ball;

        public Score p1score;
        public Score p2score;

        public int width;
        public int height;

        

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            ball = new Ball(width / 2, height / 2, 1, 1, width, height);

            p1score = new Score(1, 2, 0);
            p2score = new Score(width-1, 2, 0);

            Paddle1 = new Paddle(2, height / 2, 5);
            Paddle2 = new Paddle(width-3, height / 2, 5);
        }

        public bool Run()
        {
            Console.Clear();
            Paddle1.Draw();
            Paddle2.Draw();
            p1score.Draw();
            p2score.Draw();


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
            
            ball.CheckCollisions(Paddle1, Paddle2, width, height);

            Paddle1.Draw();
            Paddle2.Draw();

            int scorer = ball.CheckScore(width);

            if (scorer == 1)
            {
                p1score.points += 1;
                ball.Reset();
            }


            if (scorer == 2)
            {
                p2score.points += 1;
                ball.Reset();
            }
            ball.Draw();

            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
