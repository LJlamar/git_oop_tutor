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
            
            HorizontalLine line = new HorizontalLine(0, 78, 0, '+'); //пишем класс, который задействуем, затем название,
            //"присваиваем" команду создать новую "переменную"?
            line.Drow(); // собственно пишем переменную и командуем ей вывестись по методу "Drow"

            HorizontalLine rightline = new HorizontalLine(0, 78, 24, '+'); 
            rightline.Drow();

            VerticalLine top = new VerticalLine(0, 0, 24, '+'); //пишем класс, который задействуем, затем название,
            //"присваиваем" команду создать новую "переменную"?
            top.Drow(); // собственно пишем переменную и командуем ей вывестись по методу "Drow"

            VerticalLine bot = new VerticalLine(78, 0, 24, '+');
            bot.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator FoodCreator = new FoodCreator(80, 25, '@');
            Point food = FoodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = FoodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

      }
                       
            //Console.ReadLine();
    }
}
