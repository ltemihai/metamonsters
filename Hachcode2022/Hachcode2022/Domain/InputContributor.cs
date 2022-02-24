using System.Collections.Generic;

namespace Hachcode2022.Domain
{
    public class InputContributor
    {
        public string Name { get; set; }
        public Dictionary<string, InputSkill> Skills { get; } = new Dictionary<string, InputSkill>();

    }
}