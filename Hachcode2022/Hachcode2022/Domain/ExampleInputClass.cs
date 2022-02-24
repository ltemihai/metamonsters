using System.Collections.Generic;

namespace Hachcode2022.Domain
{
    public class ExampleInputClass
    {
        public List<InputContributor> Contributors { get; } = new List<InputContributor>();
        public List<InputProject> Projects { get; } = new List<InputProject>();
    }
}