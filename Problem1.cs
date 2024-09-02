namespace Problem1
{
    public class Solution {

        public int[] TwoSum(int[] nums, int target){
            Dictionary<int,int> map = [];
    		for (int i = 0; i < nums.Length; i++)
    		{
    			int complement = target - nums[i];
    			if (map.ContainsKey(complement))
    			{
    				return [map[complement], i];
    			}

    			map.TryAdd(nums[i], i);
    		}
		
    		throw new InvalidOperationException("Shouldn't be possible");
        }

        public void RunTests()
        {
            int[] nums = [2,7,11,15];
            int target = 9;

            WriteResult(nums, target, TwoSum(nums,target));

            nums = [3,2,4];
            target = 6;
            WriteResult(nums, target, TwoSum(nums,target));

            nums = [3,3];
            target = 6;
            WriteResult(nums, target, TwoSum(nums,target));
        }

        private void WriteResult(int[] nums, int target, int[] result)
        {
            Console.WriteLine($"Input: nums = [{string.Join(",", nums)}], target = {target}");
            Console.WriteLine($"Output: [{string.Join(",",result)}]");
            Console.WriteLine();
        }
    }
}