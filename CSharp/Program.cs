using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Instances
            Solution solution = new Solution();
            Timer timer = new Timer();

            #endregion


            #region Variable Declarations
            string[] words = {"gin", "zen", "gig", "msg"};

            #endregion

            timer.Start();

            var result = solution.UniqueMorseRepresentations(words);




            #region End Timer
            timer.Stop();
            #endregion

            #region Print Result
            Printer.Print(result);

            timer.Result();
            #endregion
        }
    }
}
