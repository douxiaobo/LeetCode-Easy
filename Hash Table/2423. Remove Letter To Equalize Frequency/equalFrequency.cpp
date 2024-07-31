class Solution {
public:
    bool equalFrequency(string word) {
        int digit[26]={0};
        for(int i=0;i<word.length();i++){
            digit[word[i]-'a']++;
        }
        for(int i=0;i<word.length();i++){
            int index=word[i]-'a';
            digit[index]--;
            int freqs=0;
            bool temp=true;
            for(int j=0;j<26;j++){
                if(digit[j]!=0){
                    if(freqs==0){
                        freqs=digit[j];
                    }
                    if(freqs!=digit[j]){
                        temp=false;
                    }
                }
            }
            if(temp==true){
                return true;
            }
            digit[index]++;
        }
        return false;
    }
};