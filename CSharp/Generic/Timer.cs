using System;
using System.Diagnostics;

namespace CSharp{
    public class Timer{
        private TimeSpan startingTime;
        private TimeSpan duration;

        public void Start(){
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            Console.WriteLine("Timer Started");
        }

        public void Stop(){
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);

        }

        public void Result(){
            Console.WriteLine("Timer Stopped, Running Time: " + duration.TotalMilliseconds.ToString());
        }
    }
}