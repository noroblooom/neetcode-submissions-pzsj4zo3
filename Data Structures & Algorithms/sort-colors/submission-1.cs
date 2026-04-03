public class Solution {
    public void SortColors(int[] nums) {
       int i = 0, l = 0, r = nums.Length - 1;

       while (i <= r) {
            if (nums[i] == 0) {
                swap(nums, l, i);
                l++;
            }
            else if (nums[i] == 2) {
                swap(nums, i, r);
                r--;
                i--;
            }
            i++;
       }
    }

    private void swap(int[] arr, int i, int j) {
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}