public class Solution {
    public int PivotIndex(int[] nums) {
        if (nums == null || nums.Length == 0)
            return -1;
        int sum = 0;
        foreach (int num in nums)
            sum += num;
        int length = nums.Length;
        int leftSum = 0, rightSum = sum - nums[0];
        if (leftSum == rightSum)
            return 0;
        for (int i = 1; i < length; i++) {
            leftSum += nums[i - 1];
            rightSum -= nums[i];
            if (leftSum == rightSum)
                return i;
        }
        return -1;
    }
}