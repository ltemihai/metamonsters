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
            RunTest("a_an_example.in.txt");
            RunTest("b_better_start_small.in.txt");
            RunTest("c_collaboration.in.txt");
            RunTest("d_dense_schedule.in.txt");
            RunTest("e_exceptional_skills.in.txt");
            RunTest("f_find_great_mentors.in.txt");
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