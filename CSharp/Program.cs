using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            int[] nums = {1,3,2,2,5,2,3,7};
            Timer.Start();
            var result = solution.FindLHS(nums);
            Timer.Stop();
            Printer.Print(result);
        }
    }
}
