using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StudentObserver : IObserver
    {

        public string Name { get; set; }

        public StudentObserver(string name)
        {
            Name = name;
        }

        public override void Sign(object obj)
        {
            Console.WriteLine("hello the world! from a students||" + Name);
        }
    }
}
