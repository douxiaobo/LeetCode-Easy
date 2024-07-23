class Solution:
    def countPrefixSuffixPairs(self, words: List[str]) -> int:
        result = 0  
        length = len(words)  
        for i in range(length):  
            for j in range(i + 1, length):  
                if len(words[i]) <= len(words[j]):   
                    if words[j].startswith(words[i]) and words[j].endswith(words[i]): 
                        result+=1 
        return result