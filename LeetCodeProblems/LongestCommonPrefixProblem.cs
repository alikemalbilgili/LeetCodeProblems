namespace LeetCodeProblems;

public class LongestCommonPrefixProblem : SolutionBase.SolutionBase
{
    public override void MySolution(params object[] args)
    {
        var strs = (string[])args[0];
        bool isSame = true;
        var prefix = "";
        var index = 0;
        while (isSame)
        {
            try
            {
            int i = 0;
            for (; i < strs.Length-1; i++)
            {
                if (strs[i][index] != strs[i+1][index])
                {
                    isSame = false;
                }
            }
            if (isSame)
            {
                prefix += strs[i][index];
            }

            index++;
            }
            catch (Exception e)
            {
                isSame = false;
            }
        }
            Console.WriteLine(prefix);
    }

        //This solution is very genius.
    public override void Solution(params object[] args)
    {
        var strs = (string[])args[0];
        if (strs == null || strs.Length == 0)
            Console.WriteLine("");
        Array.Sort(strs);
        String first = strs[0];
        String last = strs[strs.Length - 1];
        int c = 0;
        while(c < first.Length)
        {
            if (first[c] == last[c])
                c++;
            else
                break;
        }

        Console.WriteLine(c == 0 ? "" : first.Substring(0, c));
    
    }
}