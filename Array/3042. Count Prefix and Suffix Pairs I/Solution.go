func countPrefixSuffixPairs(words []string) int {
	result := 0
	length := len(words)
	for i := 0; i < length-1; i++ {
		for j := i + 1; j < length; j++ {
			if len(words[i]) <= len(words[j]) {
				if (words[j][:len(words[i])] == words[i]) &&
					(words[j][(len(words[j])-len(words[i])):] == words[i]) {
					result++
				}
			}

		}
	}
	return result
}

import ("strings")
func countPrefixSuffixPairs(words []string) int {
    result:=0;
    length:=len(words);
    for i:=0;i<length-1;i++{
        for j:=i+1;j<length;j++{
            if(strings.HasSuffix(words[j],words[i])&&strings.HasPrefix(words[j],words[i])){
                result++;
            }
        }
    }
    return result;
}