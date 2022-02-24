using Hachcode2022.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hachcode2022.Services
{
    public class Project
    {
        public string Name { get; set; }
        public int RequiredDays { get; set; }
        public int Reward { get; set; }
        public int Deadline { get; set; }

        public Dictionary<string, int> Roles { get; } = new Dictionary<string, int>();
    }

    public class Contributor
    {
        public string Name { get; set; }
        public Dictionary<string, int> Roles { get; } = new Dictionary<string, int>();
    }

    static class ProjectCalculator
    {
        public static List<Project> CalculatePriority(List<Project> projets, List<Contributor> contributors, Project proj)
        {
            var priorities = projets.OrderBy(proj => proj.Reward / proj.RequiredDays * proj.Roles.Count);
            return priorities.ToList();
        }
    }
}
