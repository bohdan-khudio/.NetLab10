using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Tasks
{
    public static class RectangleAndCircle
    {

        private const double pi = 3.14159265358979;

        private static int LeghtOfRectangle(Coordinate A, Coordinate C)
        {
            return C.X - A.X;
        }

        private static int WidthOfRectangle(Coordinate A, Coordinate C)
        {
            return A.Y - C.Y;
        }

        public static int SquareOfRectangle(Coordinate A, Coordinate C)
        {
            return LeghtOfRectangle(A, C) * WidthOfRectangle(A, C);
        }

        public static int PerimeterOfRectangle(Coordinate A, Coordinate C)
        {
            return 2 * (LeghtOfRectangle(A, C) + WidthOfRectangle(A, C));
        }

        public static double LeghtOfCircle(int r)
        {
            return 2 * pi * r;
        }

        public static double SquareOfCircle(int r)
        {
            return pi * r * r;
        }
    }

    public  class Task4
    {
        public void Run()
        {
            Coordinate A = new Coordinate();
            Coordinate C = new Coordinate();

            Console.WriteLine("Task 4 \nInput coordinates of the left upper corner");
           

            A.X = Convert.ToInt32(Console.ReadLine());
            A.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input coordinates of the right lower corner");
            C.X = Convert.ToInt32(Console.ReadLine());
            C.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input radius");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                 $"Rectangle \nSquare = {RectangleAndCircle.SquareOfRectangle(A, C)}, Perimetr = {RectangleAndCircle.PerimeterOfRectangle(A, C)}" +
                 $"\nCircle \nSquare = {RectangleAndCircle.SquareOfCircle(r)}, Leght = {RectangleAndCircle.LeghtOfCircle(r)}");

        }
    }
}
