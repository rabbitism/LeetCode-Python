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
            int[] a = { 3,0,8,4};
            int[] b = { 2,4,5,7};
            int[] c = { 9,2,6,3};
            int[] d = { 0,3,1,0};
            var input = new int[4][]{ a, b,c,d};

            var result = solution.MaxIncreaseKeepingSkyline(input);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
