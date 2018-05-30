using System;
using System.Diagnostics;

namespace CSharp{
    public static class Timer{
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Start(){
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine("Timer Started");
        }

        public static void Stop(){
            stopwatch.Stop();
            Console.WriteLine("Timer Stopped, Running Time: " + stopwatch.ElapsedMilliseconds.ToString());
        }
    }
}