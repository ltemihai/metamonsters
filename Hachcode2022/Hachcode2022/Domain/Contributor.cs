using System.Collections.Generic;

namespace Hachcode2022.Domain
{
    public class Contributor
    {
        public string Name { get; set; }
        public List<Skill> Skills { get; } = new List<Skill>();

    }
}