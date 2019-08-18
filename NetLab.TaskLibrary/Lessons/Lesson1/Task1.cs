using System;
using System.Collections.Generic;
using System.Text;
using NetLab.TaskLibrary;

namespace Lesson1
{

    public class Rectangle
    {
        private Coordinate A;
        private Coordinate C;
        

        public Rectangle(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
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
      public  class Task1: IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Task 1 \nInput coordinates of the left upper corner");

            Coordinate A = new Coordinate();
            Coordinate C = new Coordinate();

            try
            {

                A.X = Int32.Parse(Console.ReadLine());
                A.Y = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input coordinates of the right lower corner");
                C.X = Int32.Parse(Console.ReadLine());
                C.Y = Int32.Parse(Console.ReadLine());            

            
                Rectangle rec = new Rectangle(A, C);            

                Console.WriteLine($"Square = { rec.Square()}, Perimetr = { rec.Perimeter()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("You have not entered a number, try again");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
