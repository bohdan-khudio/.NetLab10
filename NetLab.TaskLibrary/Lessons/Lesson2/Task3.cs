using NetLab.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lesson2
{
    public class Figure3
    {
        public virtual void Drow()
        {
            Console.WriteLine(this.GetType().Name);
        }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Figure3(int x, int y)
        {
            X = x;
            Y = y;
        }

    }


    public class Rectangle3 : Figure3
    {
        public Rectangle3(int x, int y) : base(x, y)
        {

        }

    }

    public class Square3 : Figure3
    {
        public Square3(int x, int y) : base(x, y)
        {

        }

    }

    public class Task3 : IRunnable
    {


        public void Run()
        {
            try
            {
                Console.WriteLine("Enter, please, x and y");
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());
                Figure3 figura = new Figure3(x, y);
                Rectangle3 rec = new Rectangle3(x, y);
                Square3 sq = new Square3(x, y);

                figura.Drow();
                sq.Drow();
                rec.Drow();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have not entered a number, try again");
            }

        }
    }
}
