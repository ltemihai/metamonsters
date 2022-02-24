using System.Collections.Generic;
using System.IO;
using Hachcode2022.Domain;

namespace Hachcode2022.FileHandlers
{
    public class OutputWriter
    {
        public static void WriteToFile(string fileName, ExampleOutputClass outputCase)
        {
            List<string> lines = new List<string>();
            
            lines.Add("test");
            
            File.WriteAllLines(fileName, lines);
        }
    }
}