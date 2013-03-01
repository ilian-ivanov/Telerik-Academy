using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timer
{
    public delegate void TimerDelegate();   // declare delegate

    public class Timer
    {
        // the method that help to repeat other method after some time in some duration
        public static void RepeatSomeMethod(TimerDelegate method, int seconds, long durationInSeconds)
        {
            long start = 0;
            while (start <= durationInSeconds) 
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
            }
            
        }

        // the method which will use to repeat
        public static void Print()
        {
            Console.WriteLine("This text will repeat in a few seconds!");
        }

        static void Main()
        {
            Timer.RepeatSomeMethod(Print, 2, 10);
        }
    }
}
