from typing import List
from collections import Counter

class Solution:
    def kthDistinct(self, arr: List[str], k: int) -> str:
        # 使用Counter来统计每个字符串的出现次数
        count = Counter(arr)
        
        # 遍历数组，找到第k个独特的字符串
        for str in arr:
            if count[str] == 1:
                k -= 1
                if k == 0:
                    return str
        
        return ""

# 示例用法
solution = Solution()
arr = ["a", "b", "a", "c", "b"]
k = 2
print(solution.kthDistinct(arr, k))  # 输出 "c"