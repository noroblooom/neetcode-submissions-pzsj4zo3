public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> has = new HashSet<int>();
        foreach (int n in nums) {
            if (has.Contains(n)) {
                return true;
            }
            has.Add(n);
        }
        return false;
    }
}
