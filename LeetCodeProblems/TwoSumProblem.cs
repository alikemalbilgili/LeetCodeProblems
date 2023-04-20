namespace LeetCodeProblems
{
    public class TwoSumProblem : SolutionBase.SolutionBase
    {
      
        public override void MySolution(params object[] args)
        {
            //Declare parameters of solution
            int[] nums = (int[])args[0];
            int target = (int)args[1];
            
            var targetIndexs = new int[2];
            for(int i = 0 ; i<nums.Length;i++){
                for(int j = 0 ; j<i; j++){
                    if(nums[i]+nums[j]==target){
                        targetIndexs[0]=i;
                        targetIndexs[1]=j;
                        Console.WriteLine($"Result: [{targetIndexs[0]}, {targetIndexs[1]}]");
                        break;
                    }
                } 
            }
           
        }

        public override void Solution(params object[] args)
        {
            //Declare parameters of solution
            int[] nums = (int[])args[0];
            int target = (int)args[1];

            Dictionary<int, int> seen = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
              
                if(seen.ContainsKey(target-nums[i])){
                    var a =  new int[]{seen[target-nums[i]], i}; 
                    Console.WriteLine($"Result: [{seen[target-nums[i]]}, {i}]");
                }
               
                if(!seen.ContainsKey(nums[i])){
                    seen.Add(nums[i], i);
                }
            
            }
        }
    }
}