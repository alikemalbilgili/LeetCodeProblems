using LeetCodeProblems;
using SolutionBase.Utils;

namespace Main
{
    public class Program
    {
       public static void Main(string[] args)
       {
           var executionTimeCalculator = new SolutionExecutionTimeCalculator();
           
           var twoSumProblem = new TwoSumProblem();
           
           Action mySolutionAction = () => twoSumProblem.MySolution(new int[] { 2, 7, 11, 15 }, 9);
           Action solutionAction = () =>  twoSumProblem.Solution(new int[] { 2, 7, 11, 15 }, 9);
           
           executionTimeCalculator.MeasureExecutionTime(mySolutionAction);
           executionTimeCalculator.MeasureExecutionTime(solutionAction);
       }
    }
}

