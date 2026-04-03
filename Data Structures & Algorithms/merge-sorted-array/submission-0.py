class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        j = len(nums2) - 1
        cnt = 0

        for i in range(len(nums1) - 1, -1, -1):
            if cnt < n:
                nums1[i] = nums2[j]
                cnt += 1
                j -= 1
        nums1.sort()