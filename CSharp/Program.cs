using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer.Start();

            MinStack obj = new MinStack();
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            Printer.Print(obj.GetMin());
            obj.Pop();
            Printer.Print(obj.Top());
            Printer.Print(obj.GetMin());

            Timer.Stop();
        }
    }
}
