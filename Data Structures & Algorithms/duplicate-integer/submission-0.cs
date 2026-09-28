public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        for (int x = 0; x < nums.Length - 1; x++){
            if(nums[x] == nums[x+1]){
                return true;
            }
        }
        return false;
    }
}