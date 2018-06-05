using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();

            var result = solution.NumJewelsInStones("aA", "aAAbbbb");

            Printer.Print(result);

            Timer.Stop();
        }
    }
}
