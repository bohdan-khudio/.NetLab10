using System;
using System.Collections.Generic;
using System.Text;
using NetLab.TaskLibrary;

namespace Lesson1
{
    public class Circle
    {
        private int r;
        private const double pi = 3.14159265358979;

        public Circle(int r)
        {
            if (!Validator.CheckCircle(r))
                throw new ArgumentException("Radius can not be negative, try again");
            this.r = r;
        }


        public double Leght()
        {
            return 2 * pi * r;
        }

        public double Square()
        {
            return pi * r * r;
        }
    }

    public class Task3 : IRunnable
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Task 3 \nInput radus");
                int r = Int32.Parse(Console.ReadLine());
                Circle cir = new Circle(r);
                Console.WriteLine($"Square = {cir.Square()}, Leght = {cir.Leght()}");
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
