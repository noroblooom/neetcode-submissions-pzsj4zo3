public class Solution {
    public bool hasDuplicate(int[] nums) {
       var has = new HashSet<int>();
       foreach (int x in nums) {
            if (has.Contains(x)) {
                return true;
            }
            has.Add(x);
       }
       
       return false;
    }
}