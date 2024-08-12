from typing import List

class Solution:
    def findIntersectionValues(self, nums1: List[int], nums2: List[int]) -> List[int]:
        num1 = 0
        num2 = 0
        
        for num in nums1:
            if num in nums2:
                num1 += 1
        
        for num in nums2:
            if num in nums1:
                num2 += 1
        
        return [num1, num2]

# 示例用法
solution = Solution()
nums1 = [1, 2, 3, 4, 5]
nums2 = [3, 4, 5, 6, 7]
result = solution.findIntersectionValues(nums1, nums2)
print("Intersection counts:", result)
