using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();
            string[] words = {"gin", "zen", "gig", "msg"};

            var result = solution.UniqueMorseRepresentations(words);

            Printer.Print(result);
        
            Timer.Stop();
        }
    }
}
