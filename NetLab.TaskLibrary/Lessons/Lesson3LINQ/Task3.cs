using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace NetLab.TaskLibrary.Lessons.Lesson3LINQ
{
    public class Task3 : IRunnable
    {
        private Random _random = new Random(Environment.TickCount);

        public string RandomString()
        {
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
            StringBuilder builder = new StringBuilder(4);

            for (int i = 0; i < 4; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }

        public void DispalyPage(IEnumerable<string> list, int n)
        {
            
            int pageCount = 0;

            if (list.Count() % 5 == 0) pageCount = list.Count() / 5;
            else pageCount = list.Count() / 5 + 1;

            if (n < 1 || n > pageCount) Console.WriteLine("Wrong number");
            else
            {
                var newList = list.Where((s, i) => 5 * (n - 1) <= i && i < 5 * n);
                foreach (var i in newList)
                {
                    Console.Write(i + " ");
                }
            }
        }    
                            

        public void WriteList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("");
        }


        public void Run()
        {
            List<string> list = new List<string>();         //create list

            int n = 0;
            while (n < 105)
            {
                list.Add(RandomString());
                n++;
            }


            Console.WriteLine("Count before " + list.Count);       //write new list
            WriteList(list);


   

            list.Distinct();
            var newList = list.Where(s => s.First() != 'Z');

            Console.WriteLine("Count after ");
            Console.WriteLine(newList.Count().ToString());
            
            newList = newList.OrderByDescending(s => s);
           
            foreach (var i in newList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("Input page #");               // task whith pages 
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                DispalyPage(newList, num);
            }

            catch (Exception e)
            {
                System.Environment.Exit(0);
            }


        }
    }
}
