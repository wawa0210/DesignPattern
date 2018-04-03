using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MomObserver : IObserver
    {
        public string Name { get; set; }

        public MomObserver(string name)
        {
            Name = name;
        }

        public void Sign(object obj)
        {
            Console.WriteLine("I'm Mom ,I received the teacher Msg ");
        }
    }
}
