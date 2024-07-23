class Solution {
public:
    int countPrefixSuffixPairs(vector<string>& words) {
        int result = 0;
        for (int i = 0; i < words.size(); i++) {
            for (int j = i + 1; j < words.size(); j++) {
                if (words[i].size()<=words[j].size()
                &&
                words[i] == words[j].substr(0, words[i].size())
                &&
                words[i]==words[j].substr(words[j].size()-words[i].size(),words[j].size())) { // 检查子串
                    result++;
                }
            }
        }
        return result;
    }
};