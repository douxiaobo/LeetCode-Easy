#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* truncateSentence(char* s, int k) {
    int len = strlen(s);
    char* result = (char*)malloc(len + 1); // 分配足够的空间
    int j = 0;

    for (int i = 0; i < len; i++) {
        if (s[i] == ' ') {
            k--;
        }
        if (k == 0) {
            break;
        }
        result[j++] = s[i];
    }
    result[j] = '\0'; // 添加字符串结束符

    return result;
}

int main() {
    char str[] = "Hello how are you Contestant";
    int k = 4;
    char* result = truncateSentence(str, k);
    printf("Truncated sentence: %s\n", result);
    free(result); // 释放内存
    return 0;
}