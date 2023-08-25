public class Solution {
    public int DominantIndex(int[] nums) {
        int mx = int.MinValue, mid = int.MinValue;
        int ans = -1;
        for (int i = 0; i < nums.Length; ++i) {
            if (nums[i] > mx) {
                mid = mx;
                mx = nums[i];
                ans = i;
            } else if (nums[i] > mid) {
                mid = nums[i];
            }
        }
        return mx >= mid * 2 ? ans : -1;
    }
}