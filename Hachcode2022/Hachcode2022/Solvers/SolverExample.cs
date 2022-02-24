using System;
using Hachcode2022.Domain;

namespace Hachcode2022.Solvers
{
    public class SolverExample : ISolver
    {
        public ExampleOutputClass Solve(ExampleInputClass inputCase)
        {
            Console.WriteLine("Solving...");

            return new ExampleOutputClass();
        }
    }
}