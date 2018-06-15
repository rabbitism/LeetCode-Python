using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();
            int[] input = {1,2,3};

            var result = solution.MinMoves2(input);

            Printer.Print(result);
        
            Timer.Stop();
        }
    }
}
