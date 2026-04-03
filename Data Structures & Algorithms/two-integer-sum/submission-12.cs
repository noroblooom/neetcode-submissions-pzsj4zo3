public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var prevMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int sum = target - nums[i];
            if (prevMap.ContainsKey(sum)) {
                return new int[]{prevMap[sum], i};
            }
            prevMap[nums[i]] = i;
        }

        return null;
    }
}
