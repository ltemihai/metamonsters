using System.Collections.Generic;
using Hachcode2022.Domain;

namespace Hachcode2022.Services
{
    public class DataHolder
    {
        public static Dictionary<string, List<InputContributor>> _skillToContributors { get; set; } =
            new Dictionary<string, List<InputContributor>>();

        public static void recalculateSkillToContributors(List<InputContributor> contributors)
        {
            _skillToContributors = new Dictionary<string, List<InputContributor>>();
            foreach (var contributor in contributors)
            {
                foreach (var skill in contributors)
                {
                    if (!_skillToContributors.ContainsKey(skill.Name))
                    {
                        _skillToContributors.Add(skill.Name, new List<InputContributor>());
                    }
                    _skillToContributors[skill.Name].Add(contributor);
                }
            }
        }


    }

    public class ContributorSkillLevel
    {
        
    }

}