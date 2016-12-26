using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine(0, 5, 10, '+');
            //v1.Draw();

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            fSnake.Draw();
            Snake snake = (Snake)fSnake;
            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(h1);
            figures.Add(v1);

            foreach (var f in figures)
            {
                f.Draw();
            }
            Console.ReadLine();
        }
    }
}
