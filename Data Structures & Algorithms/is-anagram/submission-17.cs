public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}

        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++) {
            arr[s[i] - 'a']++;
            arr[t[i] - 'a']--;
        }

        foreach (char c in arr) {
            if (c != 0) {
                return false;
            }
        }

        return true;
    }
}
