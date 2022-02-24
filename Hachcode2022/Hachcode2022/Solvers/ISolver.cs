using Hachcode2022.Domain;

namespace Hachcode2022.Solvers
{
    public interface ISolver
    {
        public ExampleOutputClass Solve(ExampleInputClass inputCase);
    }
}