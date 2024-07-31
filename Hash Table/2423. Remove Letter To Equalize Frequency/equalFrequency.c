bool equalFrequency(char* word) {
    int digit[26] = {0};
    int len = strlen(word);
    for (int i = 0; i < len; i++) {
        digit[word[i] - 'a']++;
    }
    
    for (int i = 0; i < len; i++) {
        int index = word[i] - 'a';
        digit[index]--;
        int freqs = 0;
        bool temp = true;
        for (int j = 0; j < 26; j++) {
            if (digit[j] != 0) {
                if (freqs == 0) {
                    freqs = digit[j];
                } else if (freqs != digit[j]) {
                    temp = false;
                }
            }
        }
        if (temp) {
            return true;
        }
        digit[index]++;
    }
    
    return false;
}