public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var prevMap = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int x = target - nums[i];
            if (prevMap.ContainsKey(x)) {
                return new int[]{prevMap[x], i};
            }
            prevMap[nums[i]] = i;
        }

        return null;
    }
}
