public class Solution {
    public int HeightChecker(int[] heights) {
        int length = heights.Length;
        int[] sorted = new int[length];
        Array.Copy(heights, 0, sorted, 0, length);
        Array.Sort(sorted);
        int count = 0;
        for (int i = 0; i < length; i++) {
            if (heights[i] != sorted[i])
                count++;
        }
        return count;
    }
}