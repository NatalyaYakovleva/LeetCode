public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        int rows = accounts.Length;
        for (int i = 0; i < rows; i++)
        {
            int[] account = accounts[i];
            int sum = 0;
            foreach (int amount in account) 
                sum += amount;
            maxWealth = Math.Max(maxWealth, sum);        
        }
        return maxWealth;
    }
}