using System;
using System.Collections.Generic;
using System.Text;
using NetLab.TaskLibrary;

namespace Lesson1
{
    public static class RectangleAndCircle
    {

        private const double pi = 3.14159265358979;

        private static int LeghtOfRectangle(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
            return C.X - A.X;
        }

        private static int WidthOfRectangle(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
            return A.Y - C.Y;
        }

        public static int SquareOfRectangle(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
            return LeghtOfRectangle(A, C) * WidthOfRectangle(A, C);
        }

        public static int PerimeterOfRectangle(Coordinate A, Coordinate C)
        {
            if (!Validator.CheckRectangle(A, C))
                throw new ArgumentException("Incorrect coordinate, try again");
            return 2 * (LeghtOfRectangle(A, C) + WidthOfRectangle(A, C));
        }

        public static double LeghtOfCircle(int r)
        {
            if (!Validator.CheckCircle(r))
                throw new ArgumentException("Radius can not be negative, try again");
            return 2 * pi * r;
        }

        public static double SquareOfCircle(int r)
        {
            if (!Validator.CheckCircle(r))
                throw new ArgumentException("Radius can not be negative, try again");
            return pi * r * r;
        }
    }

    public  class Task4 : IRunnable
    {
        public void Run()
        {
            Coordinate A = new Coordinate();
            Coordinate C = new Coordinate();

            Console.WriteLine("Task 4 \nInput coordinates of the left upper corner");

            try
            {
                A.X = Int32.Parse(Console.ReadLine());
                A.Y = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input coordinates of the right lower corner");
                C.X = Int32.Parse(Console.ReadLine());
                C.Y = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input radius");
                int r = Int32.Parse(Console.ReadLine());

                Console.WriteLine(
                     $"Rectangle \nSquare = {RectangleAndCircle.SquareOfRectangle(A, C)}, Perimetr = {RectangleAndCircle.PerimeterOfRectangle(A, C)}" +
                     $"\nCircle \nSquare = {RectangleAndCircle.SquareOfCircle(r)}, Leght = {RectangleAndCircle.LeghtOfCircle(r)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter a number, try again");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
