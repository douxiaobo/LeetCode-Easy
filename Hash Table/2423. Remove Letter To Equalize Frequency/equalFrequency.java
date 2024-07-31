class Solution {
    public boolean equalFrequency(String word) {
        int[] digit=new int[26];
        for(int i=0;i<word.length();i++){
            digit[word.charAt(i) - 'a']++;
        } 
        for(int i=0;i<word.length();i++){
            int index=word.charAt(i) -'a';
            digit[index]--;
            int freqs=0;
            boolean temp=true;
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
}