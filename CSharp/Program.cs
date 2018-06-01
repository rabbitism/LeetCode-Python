using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            int[] nums = {1,2,2,4};
            Timer.Start();
            var result = solution.LongestConsecutive(nums);
            Timer.Stop();
            Printer.Print(result);
        }
    }
}
