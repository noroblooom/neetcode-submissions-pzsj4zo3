public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var sFreq = new Dictionary<char,int>();
        var tFreq = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++) {
            sFreq[s[i]] = sFreq.GetValueOrDefault(s[i], 0) + 1;
            tFreq[t[i]] = tFreq.GetValueOrDefault(t[i], 0) + 1;
        }

        return sFreq.Count == tFreq.Count && !sFreq.Except(tFreq).Any();
    }
}
