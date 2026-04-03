public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var sCount = new Dictionary<char,int>();
        var tCount = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            sCount[s[i]] = sCount.GetValueOrDefault(s[i], 0) + 1;
            tCount[t[i]] = tCount.GetValueOrDefault(t[i], 0) + 1;
        }

        return sCount.Count == tCount.Count && !sCount.Except(tCount).Any();
    }
}
