public class Solution {
    public int NumberOfSteps(int num) {
        int count = 0;
            while (num > 0) {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num--;
                count++;
            }
        return count;
    }
}