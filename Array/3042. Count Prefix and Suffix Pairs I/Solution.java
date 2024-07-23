class Solution {
    public int countPrefixSuffixPairs(String[] words) {
        int result=0;        
        for(int i=0;i<words.length+1;i++){
            for(int j=i+1;j<words.length;j++){
                if(words[i].length()<=words[j].length()){
                    if (words[j].startsWith(words[i]) && words[j].endsWith(words[i])) {  
                        // 如果 words[i] 是 words[j] 的前缀和后缀，则增加计数  
                        result++;  
                    }  
                }
            }
        }
        return result;
    }
}