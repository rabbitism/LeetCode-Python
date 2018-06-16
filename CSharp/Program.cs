using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer timer = new Timer();
            timer.Start();
            int[] input = {-1,0,1,2,-1,-4};

            var result = solution.ThreeSum(input);





            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
        
            
        }
    }
}
