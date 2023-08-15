public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (nums1.Length < m + n)
            {
                return;
            }
		int i = 0;
		int j = m; 
		while (i < n)
            {
                nums1[j++] = nums2[i++];
            }
		Array.Sort(nums1);
    }
}