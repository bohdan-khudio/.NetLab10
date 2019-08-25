using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NetLab.TaskLibrary.Lessons.Lesson3;

namespace NetLab.TaskLibrary.Lessons.Lesson3LINQ
{
    class Task1: IRunnable
    {
        public void Run()
        {
            List<Person> list = new List<Person>()
            {
            new Person("Bohdan", 22, new string[] { "+3801464566", "+380879651036", "+380189464660" }),
            new Person("Olia", 25, new string[] { "+3809955568", "+380057200136", "+38018944506" }),
            new Person("Stepan", 31, new string[] { "+38018946466", "+380314965136", "+380199446466" }),
            new Person("Kate", 34, new string[] { "+380189464486", "+38004965136", "+38018946466" }),
            new Person("Taras", 19, new string[] { "+3801894585858", "+38031469696", "+3801991325469" }),
            new Person("Ivan", 27, new string[] { "+3804654631364", "+3803464346465", "+3801996464349" })
            };

            Console.WriteLine("Task1");


            var query = list.Select(s => $"Name: {s.Name} Age: {s.Age}\n");
            Console.WriteLine(string.Join("", query));
        }
    }
}
