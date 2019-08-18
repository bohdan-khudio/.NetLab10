using System;
using System.Collections.Generic;
using System.Text;
using NetLab.TaskLibrary;

namespace Lesson2
{
    public abstract class Figure2
    {
        public abstract void Drow();
        public int X { get; private set; }
        public int Y { get; private set; }

        public Figure2(int x, int y)
        {
            X = x;
            Y = y;
        }

    }


    public class Rectangle2 : Figure2
    {
        public Rectangle2(int x, int y) : base(x, y)
        {

        }

        public override void Drow()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    public class Square2 : Figure2
    {
        public Square2(int x, int y) : base(x, y)
        {

        }

        public override void Drow()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }



    public class Task2 : IRunnable
    {


        public void Run()
        {
            try
            {
                Console.WriteLine("Enter, please, x and y");
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());
                Square2 sqr = new Square2(x, y);
                Rectangle2 rec = new Rectangle2(x, y);
                sqr.Drow();
                rec.Drow();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have not entered a number, try again");
            }

        }
    }
}
