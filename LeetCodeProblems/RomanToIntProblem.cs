namespace LeetCodeProblems
{
    public class RomanToIntProblem:SolutionBase.SolutionBase
    {
        public override void MySolution(params object[] args)
            {
                var str = (string)args[0];
                var romanSymbols = new Dictionary<char, int>
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };

                var multiplier = 1;
                var sum = 0;
                for (int i = str.Length - 1; i >= 1; i--)
                {
                    sum += (romanSymbols[str[i]] * multiplier);
                    if (romanSymbols[str[i]]>romanSymbols[str[i-1]])
                    {
                        multiplier = -1;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                }
                sum += (romanSymbols[str[0]] * multiplier);
                Console.WriteLine($"Result is: {sum}");

            }

        public override void Solution(params object[] args)
        {
            var s = (string)args[0];
            
            int[] nums=new int[s.Length];
            for(int i=0;i<s.Length;i++){
                switch (s[i]){
                    case 'M':
                        nums[i]=1000;
                        break;
                    case 'D':
                        nums[i]=500;
                        break;
                    case 'C':
                        nums[i]=100;
                        break;
                    case 'L':
                        nums[i]=50;
                        break;
                    case 'X' :
                        nums[i]=10;
                        break;
                    case 'V':
                        nums[i]=5;
                        break;
                    case 'I':
                        nums[i]=1;
                        break;
                }
            }
            int sum=0;
            for(int i=0;i<nums.Length-1;i++){
                if(nums[i]<nums[i+1])
                    sum-=nums[i];
                else
                    sum+=nums[i];
            }
            sum = sum+nums[nums.Length-1];
            Console.WriteLine($"Result is: {sum}");
        }
    }
}