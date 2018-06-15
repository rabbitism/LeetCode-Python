using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();
            int[] input = {-1,0,1,2,-1,-4};

            var result = solution.ThreeSum(input);
            Timer.Stop();

            Printer.Print(result);
        
            
        }
    }
}
