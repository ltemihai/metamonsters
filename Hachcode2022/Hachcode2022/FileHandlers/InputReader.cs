using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Hachcode2022.Domain;

namespace Hachcode2022.FileHandlers
{
    public class InputReader
    {
        public static ExampleInputClass ReadFromFile(string fileName)
        {
            var lines = File.ReadLines(fileName).ToList();

            var contributorNr = Int32.Parse(lines[0]);
            var projectNr = Int32.Parse(lines[1]);

            var lineIndex = 2;
            
            for (int i = 0; i < contributorNr; i++)
            {
                
            }
            
            Console.WriteLine(text);
            return new ExampleInputClass();
        }
        
    }
}