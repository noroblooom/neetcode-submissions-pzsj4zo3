public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        int[] nums = new int[26];
        for (int i = 0; i < s.Length; i++) {
            nums[s[i] - 'a']++;
            nums[t[i] - 'a']--;
        }

        foreach (int x in nums) {
            if (x != 0) {
                return false;
            }
        }

        return true;
    }
}
