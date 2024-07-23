class Solution:
    def scoreOfString(self, s: str) -> int:
        score = 0
        for i in range(len(s)-1):
            if s[i]>s[i+1]:
                score+=ord(s[i])-ord(s[i+1])
            else:
                score+=ord(s[i+1])-ord(s[i])
        return score
    
my_solution = Solution()
print(my_solution.scoreOfString("hello"))
print(my_solution.scoreOfString("zaz"))