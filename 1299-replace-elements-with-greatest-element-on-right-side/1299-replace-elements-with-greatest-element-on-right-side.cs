public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for (int i = arr.Length - 1, max = -1; i >= 0; --i) {
            int t = arr[i];
            arr[i] = max;
            max = Math.Max(max, t);
        }
        return arr;
    }
}