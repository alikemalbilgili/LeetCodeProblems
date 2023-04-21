using SolutionBase.Utils;

namespace SolutionBase
{

    public class ProblemExecutor
    {
        private readonly SolutionExecutionTimeCalculator _executionTimeCalculator;

        public ProblemExecutor()
        {
            _executionTimeCalculator = new SolutionExecutionTimeCalculator();
        }

        public void Execute(SolutionBase problem, object[] args)
        {
            Action mySolutionAction = () => problem.MySolution(args);
            Action solutionAction = () => problem.Solution(args);

            Console.WriteLine("My Solution:");
            _executionTimeCalculator.MeasureExecutionTime(mySolutionAction);

            Console.WriteLine("\nSolution:");
            _executionTimeCalculator.MeasureExecutionTime(solutionAction);
        }
    }
}