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
            var nums1 = new int[][]{new int[]{1,2,3},new int[]{4,5,6},new int[]{7,8,9}};

            var result = solution.Transpose(nums1);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
