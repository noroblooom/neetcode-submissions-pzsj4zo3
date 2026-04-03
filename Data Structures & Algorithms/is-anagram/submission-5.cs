public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char,int> sMatch = new Dictionary<char,int>();
        Dictionary<char,int> tMatch = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            sMatch[s[i]] = sMatch.GetValueOrDefault(s[i], 0) + 1;
            tMatch[t[i]] = tMatch.GetValueOrDefault(t[i], 0) + 1;
        }

        return sMatch.Count == tMatch.Count && !sMatch.Except(tMatch).Any();
    }
}
