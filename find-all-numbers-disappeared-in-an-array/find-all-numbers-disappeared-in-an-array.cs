public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        HashSet<int> numsSet = new HashSet<int>(nums);
        for (int i = 1; i <= nums.Length; ++i) {
            if (!numsSet.Contains(i)) {
                result.Add(i);
            }
        }
        return result;
    }
}