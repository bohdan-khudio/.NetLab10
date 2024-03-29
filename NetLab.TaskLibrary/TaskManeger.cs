﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace NetLab.TaskLibrary
{
    public class TaskManeger
    {
        public static void Run()
        {
            
            var Lessons = new Dictionary<int, Dictionary<int, IRunnable>>();

            var Lesson1 = new Dictionary<int, IRunnable>();
            Lesson1.Add(1, new Lesson1.Task1());
            Lesson1.Add(2, new Lesson1.Task2());
            Lesson1.Add(3, new Lesson1.Task3());
            Lesson1.Add(4, new Lesson1.Task4());
            Lesson1.Add(5, new Lesson1.Task5());
            Lessons.Add(1, Lesson1);

            var Lesson2 = new Dictionary<int, IRunnable>();
            Lesson2.Add(1, new Lesson2.Task1());
            Lesson2.Add(2, new Lesson2.Task2());
            Lesson2.Add(3, new Lesson2.Task3());
            Lesson2.Add(4, new Lesson2.Task4());            
            Lessons.Add(2, Lesson2);

            var Lesson3 = new Dictionary<int, IRunnable>();
            Lesson3.Add(1, new Lessons.Lesson3.Task1());
            Lesson3.Add(2, new Lessons.Lesson3.Task2());
            Lesson3.Add(3, new Lessons.Lesson3.Task3());            
            Lessons.Add(3, Lesson3);

            var Lesson4 = new Dictionary<int, IRunnable>();
            Lesson4.Add(1, new Lessons.Lesson3LINQ.Task1());
            Lesson4.Add(2, new Lessons.Lesson3LINQ.Task2());
            Lesson4.Add(3, new Lessons.Lesson3LINQ.Task3());
            Lessons.Add(4, Lesson4);



            string s = "";
            do
            {
                WriteLine("Input number of lesson");
                int numberOfLesson = Convert.ToInt32(ReadLine());
                WriteLine("Input number of task");
                int numberOfTask = Convert.ToInt32(ReadLine());

                try
                {
                    Lessons[numberOfLesson][numberOfTask].Run();
                }
                catch
                {
                    WriteLine("This lesson or task is not present");
                }
                WriteLine("\nRepeat? y/n");
                s = ReadLine().ToLower();

            } while (s == "y");



        }

    }
}

