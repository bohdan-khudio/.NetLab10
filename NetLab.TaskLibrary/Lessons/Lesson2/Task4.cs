using NetLab.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lesson2
{
    public interface IDrawable
    {
        void Drow();
    }


    public class Figure4 : IDrawable
    {
        public virtual void Drow()
        {
            Console.WriteLine(this.GetType().Name);
        }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Figure4(int x, int y)
        {
            X = x;
            Y = y;
        }
        
    }


    public class Rectangle4 : Figure4
    {
        public Rectangle4(int x, int y) : base(x, y)
        {

        }

    }

    public class Square4 : Figure4
    {
        public Square4(int x, int y) : base(x, y)
        {

        }

    }





    public class Task4 : IRunnable
    {
        public void DrawAll(params IDrawable[] array)
        {
            for (int i=0; i < array.Length; i++)
            {
                array[i].Drow();
            }
        }


        public void Run()
        {
            try
            {
                Console.WriteLine("Enter, please, x and y");
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());
                Figure4 figura = new Figure4(x, y);
                Rectangle4 rec = new Rectangle4(x, y);
                Square4 sq = new Square4(x, y);
                DrawAll(figura, rec, sq);
            }
            catch (FormatException)
            {
                Console.WriteLine("You have not entered a number, try again");
            }

        }
    }
}
