using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Instances
            Solution solution = new Solution();
            Timer.Start();
            int[] input = {-1,0,1,2,-1,-4};

            var result = solution.ThreeSum(input);
            Timer.Stop();




            #region End Timer
            Timer.Stop();
            #endregion

            #region Print Result
            Printer.Print(result);
        
            
        }
    }
}
