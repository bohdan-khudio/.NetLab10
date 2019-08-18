using NetLab.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lesson2
{
    
        public abstract class Figure
        {
            public abstract void Drow();           

        }

        public class Square : Figure
        {

            public override void Drow()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }


        public class Rectangle : Figure
        {            

            public override void Drow()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }


        public class Task1 : IRunnable
        {          
           public void Run()
            {
                Square sqr = new Square();
                Rectangle rec = new Rectangle();
                sqr.Drow();
                rec.Drow();
            }
        }    
}
