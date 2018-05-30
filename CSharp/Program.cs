using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            int[] nums = {2,7,11,15};
            Timer.Start();
            var result = solution.TwoSum(nums, 9);
            Timer.Stop();
            Printer.Print(result);
        }
    }
}
