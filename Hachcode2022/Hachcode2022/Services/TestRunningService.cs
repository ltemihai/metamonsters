using System;
using Hachcode2022.FileHandlers;
using Hachcode2022.Solvers;

namespace Hachcode2022.Services
{
    public class TestRunningService
    {

        private readonly ISolver _solver;

        public TestRunningService(ISolver solver)
        {
            _solver = solver;
        }

        public void RunAllTests()
        {
            RunTest("test1.txt");
            RunTest("test1.txt");
            RunTest("test1.txt");
            RunTest("test1.txt");
        }

        public void RunTest(string fileName)
        {
            Console.WriteLine($"Solving test {fileName}...");

            var inputPath = @"..\..\..\inputs\" + fileName; 
            var outputPath = @"..\..\..\outputs\" + fileName; 
            
            var inputCase = InputReader.ReadFromFile(inputPath);
            Console.WriteLine("Read input data. Solving...");
            
            var outputCase = _solver.Solve(inputCase);
            
            Console.WriteLine("Solved! Writing to file...");
            OutputWriter.WriteToFile(outputPath, outputCase);
            Console.WriteLine("Finished test");
        }
        
    }
}