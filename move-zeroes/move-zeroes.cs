public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0, n = nums.Length;
        for (int right = 0; right < n; ++right) {
            if (nums[right] != 0) {
                int t = nums[left];
                nums[left] = nums[right];
                nums[right] = t;
                ++left;
            }
        }
    }
}