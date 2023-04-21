using LeetCodeProblems;
using SolutionBase;

namespace Main
{
    public class Program
    {
       public static void Main(string[] args)
       {
           var problemExecutor = new ProblemExecutor();
           problemExecutor.Execute(new TwoSumProblem(), new object[] { new int[] { 2, 7, 11, 15 }, 9 });
       }
    }
}

