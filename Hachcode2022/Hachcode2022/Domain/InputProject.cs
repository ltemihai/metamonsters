using System.Collections.Generic;

namespace Hachcode2022.Domain
{
    public class InputProject
    {
        public string Name { get; set; }
        public int RequiredDays { get; set; }
        public int Reward { get; set; }
        public int Deadline { get; set; }

        public List<InputRole> roles { get; } = new List<InputRole>();
    }
}