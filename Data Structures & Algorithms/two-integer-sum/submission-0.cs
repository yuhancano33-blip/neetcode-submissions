public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var n = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int sum = target - nums[i];
            if(n.TryGetValue(sum, out int j)){
                return new int[] {j, i};
            }
            n[nums[i]] = i; 
        }
        return new int[0];
    }
}
