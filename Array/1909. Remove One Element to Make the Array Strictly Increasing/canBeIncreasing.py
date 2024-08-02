class Solution:
    def canBeIncreasing(self, nums: List[int]) -> bool:
        for i in range(len(nums)):
            temp = []
            for j in range(len(nums)):
                if i != j:
                    temp.append(nums[j])
            increasing = True
            for k in range(len(temp) - 1):
                if temp[k] >= temp[k + 1]:
                    increasing = False
            if increasing:
                return True
        return False