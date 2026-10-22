public class Solution {
    public bool hasDuplicate(int[] nums) {
        var values = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(values.ContainsKey(nums[i])){
                return true;
            }
            values[nums[i]] = i;
        }
        return false;
    }
}