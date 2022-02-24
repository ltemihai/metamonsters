using System;
using Hachcode2022.Services;
using Hachcode2022.Solvers;

namespace Hachcode2022
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            
            // TODO Define solvers here
            var solver = new SolverExample();
            
            // TODO Change solver used here
            var testRunner = new TestRunningService(solver);
            testRunner.RunAllTests();
            Console.WriteLine("Finished!");
        }
    }
}