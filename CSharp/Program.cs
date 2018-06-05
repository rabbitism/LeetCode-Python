using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();
            var result = solution.JudgeSquareSum(2147483646);
            Printer.Print(result);
            Timer.Stop();
        }
    }
}
