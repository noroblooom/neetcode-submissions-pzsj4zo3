class Solution:
    def sortArray(self, nums: List[int]) -> List[int]:
        
        def partition(arr, l, r):
            m = (l + r) >> 1
            arr[m], arr[l + 1] = arr[l + 1], arr[m]

            if arr[l] > arr[r]:
                arr[l], arr[r] = arr[r], arr[l]
            if arr[l] > arr[l + 1]:
                arr[l], arr[l + 1] = arr[l + 1], arr[l]
            if arr[l + 1] > arr[r]:
                arr[l + 1], arr[r] = arr[r], arr[l + 1]
            
            pivot = arr[l + 1]
            i = l + 1
            j = r

            while True:
                while True:
                    i += 1
                    if not arr[i] < pivot:
                        break
                while True:
                    j -= 1
                    if not arr[j] > pivot:
                        break
                if i > j:
                    break
                nums[i], nums[j] = nums[j], nums[i]
            
            nums[j], nums[l + 1] = nums[l + 1], nums[j]
            return j

        
        def quickSort(arr, l, r):
            if r <= l + 1:
                if r == l + 1 and nums[r] < nums[l]:
                    nums[l], nums[r] = nums[r], nums[l]
                return

            j = partition(arr, l, r)
            quickSort(arr, l, j - 1)
            quickSort(arr, j + 1, r)
        

        quickSort(nums, 0, len(nums) - 1)
        return nums