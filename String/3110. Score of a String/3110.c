#include <stdio.h>

// int scoreOfString(char* s) {
//     int score=0;
//     for(int i=1;s[i]!='\0';i++){
//         if(s[i]>s[i-1]){
//             score+=s[i]-s[i-1];
//         } else {
//             score+=s[i-1]-s[i];
//         }
//     }
//     return score;
// }

int scoreOfString(char* s) {
    int score = 0;
    for(int i = 0; s[i+1]; i++) { // 修改循环条件
        if(s[i] > s[i+1]) {
            score += s[i] - s[i+1];
        } else {
            score += s[i+1] - s[i];
        }
    }
    return score;
}

int main(){
    char str1[] = "hello";
    char str2[] = "zaz";

    int score1 = scoreOfString(str1); // 存储函数返回值
    int score2 = scoreOfString(str2);

    printf("Score of \"%s\": %d\n", str1, score1); // 输出结果
    printf("Score of \"%s\": %d\n", str2, score2);

    return 0;
}