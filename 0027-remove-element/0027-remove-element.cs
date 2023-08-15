public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0, n = nums.Length;
            for (int i = 0; i < n; ++i) {
                if (nums[i] == val)
                    ++count;
                else
                    nums[i - count] = nums[i];
            }
        return n - count;
    }
}