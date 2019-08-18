using NetLab.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{

    public class Rectangle2
    {
        private Coordinate A;
        private Coordinate C;

        public int GetPerimeter { get; private set; }
        public int GetSquare { get; private set; }


        public Rectangle2(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
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
    public class Task2: IRunnable
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

            Rectangle2 rec = new Rectangle2(A, C);

            Console.WriteLine($"Square = { rec.GetSquare}, Perimetr = { rec.GetPerimeter}");
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
