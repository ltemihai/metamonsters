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
            var inputCase = new ExampleInputClass();
            
            var contributorNr = Int32.Parse(lines[0]);
            var projectNr = Int32.Parse(lines[1]);

            var lineIndex = 2;
            
            for (int i = 0; i < contributorNr; i++)
            {
                var contributor = new InputContributor();
                var tokens = lines[lineIndex].Split(" ");
                contributor.Name = tokens[0];
                var skillNr = Int32.Parse(tokens[1]);
                for (int j = 0; j < skillNr; j++)
                {
                    tokens = lines[lineIndex + j].Split(" ");
                    var skill = new InputSkill()
                    {
                        Name = tokens[0],
                        Level = Int32.Parse(tokens[1])
                    };
                    contributor.Skills.Add(skill);
                }

                inputCase.Contributors.Add(contributor);
                lineIndex += skillNr + 1;
            }


            for (int i = 0; i < projectNr; i++)
            {
                var project = new InputProject();
                var tokens = lines[lineIndex].Split(" ");
                project.Name = tokens[0];
                project.RequiredDays = Int32.Parse(tokens[1]);
                project.Reward = Int32.Parse(tokens[2]);
                project.Deadline = Int32.Parse(tokens[3]);
                var roleNr = Int32.Parse(tokens[4]);

                for (int j = 0; j < roleNr; j++)
                {
                    tokens = lines[lineIndex + j].Split(" ");
                    var role = new InputRole()
                    {
                        Name = tokens[0],
                        Level = Int32.Parse(tokens[1])
                    };
                    project.roles.Add(role);
                }
                
                inputCase.Projects.Add(project);
                lineIndex += roleNr + 1;
            }
            
            return inputCase;
        }
        
    }
}