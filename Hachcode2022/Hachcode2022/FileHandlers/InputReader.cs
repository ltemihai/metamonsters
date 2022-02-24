using System;
using System.IO;
using Hachcode2022.Domain;

namespace Hachcode2022.FileHandlers
{
    public class InputReader
    {
        public static ExampleInputClass ReadFromFile(string fileName)
        {
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);
            return new ExampleInputClass();
        }
        
    }
}