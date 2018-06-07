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
            string[] words = {"gin", "zen", "gig", "msg"};

            var result = solution.UniqueMorseRepresentations(words);
            timer.Stop();

            Printer.Print(result);

            timer.Result();
        }
    }
}
