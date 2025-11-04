using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Labb2_ConsolePong;

namespace Labb2_ConsolePong
{
    public class Score
    {


        public int x;
        public int y;
        public int points = 0;

        public Score(int x, int y, int points)
        {
            this.x = x;
            this.x = x;
            this.points = points;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(points);
        }
    }
}
