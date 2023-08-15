public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0, sum = 0;
            foreach (int num in nums)
            {
                sum = (sum + num) * num;
                result = Math.Max(sum, result);
            }
        return result;
    }
}