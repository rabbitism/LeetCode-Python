using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();

            var result = solution.CountBinarySubstrings("00110");

            Printer.Print(result);

            Timer.Stop();
        }
    }
}
