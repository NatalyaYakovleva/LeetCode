public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums == null || nums.Length == 0) {
	            return 0;
	        }

	        int i = 0; 
	        int j = 0; 

	        while(j < nums.Length) {
	            while(j < nums.Length && nums[j] == val) {
	                j++;
	            }

	            // protect index j+1
	            if(j < nums.Length) {
	                nums[i] = nums[j];

	                i++;
	                j++;
	            }
	        }

	        return i;
    }
}