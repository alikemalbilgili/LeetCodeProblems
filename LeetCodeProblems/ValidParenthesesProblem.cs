using System.Threading.Channels;

namespace LeetCodeProblems;

public class ValidParenthesesProblem : SolutionBase.SolutionBase
{
    public override void MySolution(params object[] args)
    {
        var s = (string)args[0];
        var openBrackets = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        int i = 0;
        while (i < s.Length - 1)
        {
            char chr;
            if (openBrackets.TryGetValue(s[i], out chr) && chr == s[i + 1])
            {
                s = s.Remove(i, 2);
                i = 0;
            }
            else
            {
                i++;
            }
        }

        if (s == "")
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }

    public override void Solution(params object[] args)
    {
        var s = (string)args[0];
        Stack<char> chars = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            if (current == '{' || current == '[' || current == '(')
                chars.Push(current);
            else if (chars.Count == 0)
            {
                Console.WriteLine(false);
                break;
            }
            else if (current == '}' && chars.Peek() == '{')
                chars.Pop();
            else if (current == ')' && chars.Peek() == '(')
                chars.Pop();
            else if (current == ']' && chars.Peek() == '[')
                chars.Pop();
            else
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(chars.Count == 0);
    }
}