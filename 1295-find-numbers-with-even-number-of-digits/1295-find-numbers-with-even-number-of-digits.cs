public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
            for(int i = 0; i < nums.Length; i++){
                int s = nums[i];
                int cnt = 0;
                while(s != 0){
                    cnt++;
                    s = s / 10;
                }
                if(cnt % 2 == 0)
                    result++;
            }
        return result;
    }
}