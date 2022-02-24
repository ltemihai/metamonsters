using System.Collections.Generic;
using Hachcode2022.Domain;

namespace Hachcode2022.Services
{
    public class ColaboratorService
    {

        public static List<RoleOwnership> CalculateColaboratorWorth(List<InputRole> roles)
        {
            var r = new List<RoleOwnership>();
            var skillToContributor = DataHolder._skillToContributors;
            foreach (var role in roles)
            {
                var roleOwnership = new RoleOwnership();
                var possibleContributors= skillToContributor[role.Name];
                foreach (var contributor in possibleContributors)
                {
                    var level = contributor.Skills[role.Name].Level;
                    if (level > role.Level)
                    {
                        roleOwnership.readyToSolve.Add(contributor);
                    }
                    else
                    {
                        if (level == role.Level)
                        {
                            roleOwnership.readyToLearn.Add(contributor);
                        }
                        if (level == role.Level - 1)
                        {
                            roleOwnership.readyForMentor.Add(contributor);
                        }
                    }
                }
                r.Add(roleOwnership);
            }
            
            return r;
        }
    }

    public class RoleOwnership
    {
        public List<InputContributor> readyToLearn { get; } = new List<InputContributor>();
        public List<InputContributor> readyForMentor { get; } = new List<InputContributor>();
        public List<InputContributor> readyToSolve { get; } = new List<InputContributor>();
    }
    
}