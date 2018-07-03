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
            var input1 = LinkedListGenerator.ArrayToLinkedList(new int[]{1,1,1,1,1,1,1});
            Printer.Print(input1);

            var result = solution.DeleteDuplicates(input1);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
