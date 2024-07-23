#include <iostream>
#include <string>

class Solution {
public:
    int scoreOfString(std::string s) {
        int score=0;
        for(int i=0;i<s.length()-1;i++){
            if(s[i]>s[i+1]){
                score+=s[i]-s[i+1];
            } else {
                score+=s[i+1]-s[i];
            }
        }
        return score;
    }
    
};
int main(){
    Solution sol;
    std::cout<<sol.scoreOfString("leetcode")<<std::endl;
    std::cout<<sol.scoreOfString("hello")<<std::endl;   //13
    std::cout<<sol.scoreOfString("zaz")<<std::endl;     //50
    return 0;
}