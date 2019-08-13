using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Tasks
{

    public class Rectangle2
    {
        private Coordinate A;
        private Coordinate C;

        public int GetPerimeter { get; private set; }
        public int GetSquare { get; private set; }


        public Rectangle2(Coordinate A, Coordinate C)
        {
            this.A = A;
            this.C = C;
            GetSquare = Leght() * Width();
            GetPerimeter = 2 * (Leght() + Width());
        }

        private int Leght()
        {
            return C.X - A.X;
        }

        private int Width()
        {
            return A.Y - C.Y;
        }     

    }
    public class Task2
    {
        public void Run()
        {
            Console.WriteLine("Task 1 \nInput coordinates of the left upper corner");

            Coordinate A = new Coordinate();
            Coordinate C = new Coordinate();

            A.X = Convert.ToInt32(Console.ReadLine());
            A.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input coordinates of the right lower corner");
            C.X = Convert.ToInt32(Console.ReadLine());
            C.Y = Convert.ToInt32(Console.ReadLine());

            Rectangle2 rec = new Rectangle2(A, C);

            Console.WriteLine($"Square = { rec.GetSquare}, Perimetr = { rec.GetPerimeter}");
        }
    }
}
