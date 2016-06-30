using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework
{
    public static class Timer
    {
        public static void ShowTime(int miliseconds)
        {
            Thread.Sleep(miliseconds);
            Console.WriteLine(DateTime.Now);
        }
    }
}
