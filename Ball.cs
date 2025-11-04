namespace Labb2_ConsolePong
{
    internal class Ball
    {
        private int x;
        private int y;
        private int xVelocity;
        private int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }

        public void Move()
        {
            
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
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
            if (x == p1.x+1 && y <= p1.y + p1.size && y >= p1.size)
            {
                xVelocity = xVelocity * -1;
            }
            if (x == p2.x-1 && y <= p2.y + p2.size && y >= p2.size)
            {
                xVelocity = xVelocity * -1;
            }

        }
    }
}
