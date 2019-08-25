using System;
using System.Collections.Generic;
using System.Text;

namespace NetLab.TaskLibrary.Lessons.Lesson3
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


        public void DispalyPage(List<string> list, int n)
        {
            int pageCount = 0;

            if (list.Count % 5 == 0) pageCount = list.Count / 5;
            else pageCount = list.Count / 5 + 1;

            if (n < 1 || n > pageCount) Console.WriteLine("Wrong number");
            else
            {
                if (n == pageCount)
                {
                    Console.WriteLine($"Page {n}");
                    for (int i = 5 * (n - 1); i < list.Count; i++)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine($"Page {n}");
                    for (int i = 5 * (n - 1); i < 5 * n; i++)
                    {
                        Console.Write(list[i] + " ");
                    }
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


            for (int i = 0; i < list.Count; i++)         // deleted elements where first letter "Z" 
            {
                if (list[i][0] == 'Z')
                {
                    Console.WriteLine("Deleted " + list[i] + " first " + list[i][0]);
                    list.RemoveAt(i);
                    --i;
                }
            }
            Console.WriteLine("Count after " + list.Count);


            list.Sort();
            list.Reverse();                             // sorted and write list 
            WriteList(list);


            Console.WriteLine("Input page #");               // task whith pages 
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                DispalyPage(list, num);
            }

            catch (Exception e)
            {
                System.Environment.Exit(0);
            }

        }
    }
}
