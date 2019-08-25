using System;
using System.Collections.Generic;
using System.Text;

namespace NetLab.TaskLibrary.Lessons.Lesson3
{
    class Person
    {
        public Person(string name, int age, IEnumerable<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
