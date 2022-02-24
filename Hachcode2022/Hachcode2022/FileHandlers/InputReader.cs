using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
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
                var contributor = new Contributor();
                var tokens = lines[lineIndex].Split(" ");
                contributor.Name = tokens[0];
                var skillNr = Int32.Parse(tokens[1]);
                for (int j = 0; j < skillNr; j++)
                {
                    tokens = lines[lineIndex + j].Split(" ");
                    var skill = new Skill()
                    {
                        Name = tokens[0],
                        Level = Int32.Parse(tokens[1])
                    };
                    contributor.Skills.Add(skill);
                }

                lineIndex += skillNr + 1;
            }
            
            return new ExampleInputClass();
        }
        
    }
}