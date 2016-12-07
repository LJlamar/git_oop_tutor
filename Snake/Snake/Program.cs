using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+'); //пишем класс, который задействуем, затем название,
            //"присваиваем" команду создать новую "переменную"?
            line.Drow(); // собственно пишем переменную и командуем ей вывестись по методу "Drow"

            VerticalLine lin = new VerticalLine(5, 9, 14, '+'); //пишем класс, который задействуем, затем название,
            //"присваиваем" команду создать новую "переменную"?
            lin.Drow(); // собственно пишем переменную и командуем ей вывестись по методу "Drow"

            Console.ReadLine();
        }
    }
}
