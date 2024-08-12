class Solution:
    def truncateSentence(self, s: str, k: int) -> str:
        result = ""
        for ch in s:
            if ch == ' ':
                k -= 1
            if k == 0:
                break
            result += ch
        return result

# 测试代码
if __name__ == "__main__":
    sol = Solution()
    s = "Hello how are you Contestant"
    k = 4
    result = sol.truncateSentence(s, k)
    print("Truncated sentence:", result)