public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int result=0;
        for(int i=0;i<words.Length-1;i++){
            for(int j=i+1;j<words.Length;j++){
                if(words[i].Length>words[j].Length){
                    continue;
                } else {
                    if(words[j].StartsWith(words[i])&&words[j].EndsWith(words[i])){
                        result++;
                    }
                }
            }
        }
        return result;
    }
}