public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int n = arr.Length;
            if (n < 3) {
                return false;
            }
        int l = 0, r = n - 1;
            while (l + 1 < n - 1 && arr[l] < arr[l + 1]) {
                ++l;
            }
            while (r - 1 > 0 && arr[r] < arr[r - 1]) {
                --r;
            }
        return l == r;
    }
}