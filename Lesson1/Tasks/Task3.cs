using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Tasks
{
    public class Circle
    {
        private int r;
        private const double pi = 3.14159265358979;

        public Circle(int r)
        {
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

    public class Task3
    {
        public void Run()
        {
            Console.WriteLine("Task 3 \nInput radus");
            int r = Convert.ToInt32(Console.ReadLine());
            Circle cir = new Circle(r);
            Console.WriteLine($"Square = {cir.Square()}, Leght = {cir.Leght()}");
        }
    }
}
