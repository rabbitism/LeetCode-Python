using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer timer = new Timer();
            timer.Start();
            var nums1 = new int[]{1,3,5,2,4};
            var nums2 = new int[]{6,5,4,3,2,1,7};

            var result = solution.NextGreaterElement(nums1,nums2);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
