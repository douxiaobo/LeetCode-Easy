int countPrefixSuffixPairs(char** words, int wordsSize) {
    int result = 0;
    for (int i = 0; i < wordsSize - 1; i++) {
        for (int j = i + 1; j < wordsSize; j++) {
            // 首先判断words[i]是否<=words[j]
            if (strcmp(words[i], words[j]) <= 0) {
                bool isPrefixAndSuffix = true;
                int prefixLength = strlen(words[i]);
                // 然后判断words[i]是否是words[j]的前缀
                for (int k = 0; k < prefixLength; k++) {
                    if (words[i][k] != words[j][k]) {
                        isPrefixAndSuffix = false;
                        break;
                    }
                }
                // 最后判断words[i]是否是words[j]的后缀
                if (isPrefixAndSuffix) {
                    int suffixLength = strlen(words[j]) - prefixLength;
                    for (int k = 0; k < prefixLength; k++) {
                        if (words[i][k] != words[j][suffixLength + k]) {
                            isPrefixAndSuffix = false;
                            break;
                        }
                    }
                }
                if (isPrefixAndSuffix) {
                    result++;
                }
            }
        }
    }
    return result;
}