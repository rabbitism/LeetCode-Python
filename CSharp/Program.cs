using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            int[] nums = {1,2,2,4};
            Timer.Start();
            //var result = solution.FindErroNums(nums);
            AllOne obj = new AllOne();
            obj.Inc("hello");
            obj.Inc("hello");
            Printer.Print(obj.GetMaxKey());
            Printer.Print(obj.GetMinKey());
            obj.Inc("leet");
            Printer.Print(obj.GetMaxKey());
            Printer.Print(obj.GetMinKey());
            Timer.Stop();
            //Printer.Print(result);
        }
    }
}
