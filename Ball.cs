using System;
using Labb2_ConsolePong;

namespace Labb2_ConsolePong
{
    public class Ball
    {
        private int x;
        private int y;

        int maxWidth;
        int maxHeight;

        private int xVelocity;
        private int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity, int maxWidth, int maxHeight)
        {
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
        }

        public void Move()
        {
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()
        {
            if (x >= 0 && x < maxWidth && y >= 0 && y < maxHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("O");
            }
                
        }

        public void CheckCollisions(Paddle p1, Paddle p2, int width, int height)
        {
            if (y <= 0)
            {
                yVelocity = yVelocity * -1;
            }

            if (y >= height - 1)
            {
                yVelocity = yVelocity * -1;
            }
            if (x == p1.x + 1 && y <= p1.y + p1.size && y >= p1.y)
            {
                xVelocity = xVelocity * -1;
            }
            if (x == p2.x - 1 && y <= p2.y + p2.size && y >= p2.y)
            {
                xVelocity = xVelocity * -1;
            }
        }

        public int CheckScore(int width)
        {
            if (x >= width) return 1;
            if (x <= 0) return 2;
            return 0;
            
            
        }

        public void Reset()
        {
            x = maxWidth / 2;
            y = maxHeight / 2;
        }

    }
}



