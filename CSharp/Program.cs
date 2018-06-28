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
            var input = "5F3Z-2e-9-w5F3Z-2e-9-w5F3Z-2e-9-w5F3Z-2e-9-w5F3Z-2e-9-w";

            var result = solution.LicenseKeyFormatting(input,6);
            

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
