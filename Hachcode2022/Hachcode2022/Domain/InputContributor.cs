using System.Collections.Generic;

namespace Hachcode2022.Domain
{
    public class InputContributor
    {
        public string Name { get; set; }
        public List<InputSkill> Skills { get; } = new List<InputSkill>();

    }
}