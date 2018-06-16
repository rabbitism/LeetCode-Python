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
            var input = 12;

            var result = solution.MinSteps(input);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
        
            
        }
    }
}
