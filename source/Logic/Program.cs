using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var logic = new BussinessLogic();
            var result = logic.Calculate(4, 5);
            Console.WriteLine($"result: {result}");
        }
    }
}
