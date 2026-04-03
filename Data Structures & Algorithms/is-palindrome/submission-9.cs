public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length-1;
        while (l < r) {
            while (!alphaNum(s[l]) && l < r) {l++;}
            while (!alphaNum(s[r]) && r > l) {r--;}

            if (char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    private bool alphaNum(char c) {
        return (c >= 'a' && c <= 'z' ||
                c >= 'A' && c <= 'Z' ||
                c >= '0' && c <= '9');
    }
}
