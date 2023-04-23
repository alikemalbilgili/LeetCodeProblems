using LeetCodeProblems;
using SolutionBase;

namespace Main
{
    public class Program
    {
       public static void Main(string[] args)
       {
           var problemExecutor = new ProblemExecutor();
           
           //problemExecutor.Execute(new TwoSumProblem(), new object[] { new int[] { 2, 7, 11, 15,24,53,82,91,103,1,37,56 }, 109 });
           //problemExecutor.Execute(new RomanToIntProblem(),new object[] {"MCMXCIV"});
           problemExecutor.Execute(new LongestCommonPrefixProblem(),new object[] {new string[]  {"flome","flozz","flomer"}});
       }
    }
}

