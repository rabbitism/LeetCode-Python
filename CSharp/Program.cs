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
            var input1 = LinkedListGenerator.ArrayToLinkedList(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            var input2 = new int[]{0,1,3};
            Printer.Print(input1);

            var result = solution.SplitListToParts(input1,3);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
