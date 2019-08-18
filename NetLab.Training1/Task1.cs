using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Tasks
{

    public class Rectangle
    {
        private Coordinate A;
        private Coordinate C;
        

        public Rectangle(Coordinate A, Coordinate C)
        {
            this.A = A;
            this.C = C;        
        }

        private int Leght()
        {
            return C.X - A.X;
        }

        private int Width()
        {
            return A.Y - C.Y;
        }

        public int Square()
        {
            return Leght() * Width();
        }

        public int Perimeter()
        {
            return 2 * (Leght() + Width());
        }

    }
      public  class Task1
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
           
            Rectangle rec = new Rectangle(A, C);

            Console.WriteLine($"Square = { rec.Square()}, Perimetr = { rec.Perimeter()}");
        }
    }
}
