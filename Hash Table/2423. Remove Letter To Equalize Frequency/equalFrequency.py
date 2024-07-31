class Solution:
    def equalFrequency(self, word: str) -> bool:
        digit = [0] * 26
        for i in range(len(word)):
            digit[ord(word[i]) - ord('a')] += 1
        
        for i in range(len(word)):
            index = ord(word[i]) - ord('a')
            digit[index] -= 1
            freqs = 0
            temp = True
            for j in range(26):
                if digit[j] != 0:
                    if freqs == 0:
                        freqs = digit[j]
                    elif freqs != digit[j]:
                        temp = False
                        break
            
            if temp:
                return True
            
            digit[index] += 1
        
        return False