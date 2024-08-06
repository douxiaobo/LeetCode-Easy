class Solution:
    def missingInteger(self, nums: List[int]) -> int:
        sum = nums[0]
        prefix = False
        for i in range(1, len(nums)):
            if nums[i - 1] == nums[i] - 1:
                sum += nums[i]
            else:
                break
        while True:
            prefix = True
            for i in range(len(nums)):
                if nums[i] == sum:
                    sum += 1
                    prefix = False
            if prefix:
                break
        return sum