from typing import List
class Solution:
    def minimumOperations(self, nums: List[int]) -> int:
        result=0
        for num in nums:
            if num%3!=0:
                result+=1
        return result
    
if __name__ == "__main__":
    sol = Solution()
    nums1 = [1, 2, 3, 4]
    nums2 = [3, 6, 9]

    print(f"Minimum operations for nums1: {sol.minimumOperations(nums1)}")
    print(f"Minimum operations for nums2: {sol.minimumOperations(nums2)}")