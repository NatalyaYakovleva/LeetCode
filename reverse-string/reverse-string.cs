public class Solution {
    public void ReverseString(char[] s) {
        for (int i = 0, j = s.Length - 1; i < j; ++i, --j) {
            char t = s[i];
            s[i] = s[j];
            s[j] = t;
        }
    }
}