using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Tasks
{
    public class ComplexNumber
    {
        private double a, bi;

        public ComplexNumber(double a, double bi)
        {
            this.a = a;
            this.bi = bi;
        }


        #region Overloaded operators
        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            ComplexNumber res = new ComplexNumber(0, 0);
            res.a = complex1.a * complex2.a - complex1.bi * complex2.bi;
            res.bi = complex1.a * complex2.bi + complex1.bi * complex2.a;
            return res;
        }

        public static ComplexNumber operator /(ComplexNumber complex1, ComplexNumber complex2)
        {
            ComplexNumber res = new ComplexNumber(0, 0);
            res.a = (complex1.a * complex2.a + complex1.bi * complex2.bi) / (complex2.a * complex2.a + complex2.bi * complex2.bi);
            res.bi = (-1) * (complex1.a * complex2.bi - complex1.bi * complex2.a) / (complex2.a * complex2.a + complex2.bi * complex2.bi);
            return res;
        }
        #endregion  

        #region Overloaded method
        public override string ToString()
        {
            if (this.bi >= 0)
                return String.Format("{0}+{1}i", this.a, this.bi);
            else return String.Format("{0}{1}i", this.a, this.bi);
        }
        #endregion        

    }

    public class Task5
    {
        public void Run()
        {
            Console.WriteLine("Task 5 \nInput complex number");
            int a = Convert.ToInt32(Console.ReadLine());
            int bi = Convert.ToInt32(Console.ReadLine());
            ComplexNumber Num1 = new ComplexNumber(a, bi);

            a = Convert.ToInt32(Console.ReadLine());
            bi = Convert.ToInt32(Console.ReadLine());
            ComplexNumber Num2 = new ComplexNumber(a, bi);

            Console.WriteLine($"Product = {Num1 * Num2},  Faction = {Num1 / Num2}");
        }
    }
}
