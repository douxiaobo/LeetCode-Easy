#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char * interpret(char * command) {
    int len = strlen(command);
    char * result = (char *)malloc(len + 1); // 分配足够的空间
    int resultIndex = 0;
    int bracket = 0;
    char temp[100] = ""; // 假设括号内的内容不超过100个字符
    int tempIndex = 0;

    for (int i = 0; i < len; i++) {
        char ch = command[i];
        if (ch == '(') {
            bracket = 1;
        } else if (ch == ')') {
            if (temp[0] == '\0') {
                result[resultIndex++] = 'o';
            } else {
                strcpy(result + resultIndex, temp);
                resultIndex += strlen(temp);
                temp[0] = '\0';
                tempIndex = 0;
            }
            bracket = 0;
        } else if (bracket) {
            temp[tempIndex++] = ch;
            temp[tempIndex] = '\0';
        } else {
            result[resultIndex++] = ch;
        }
    }
    result[resultIndex] = '\0'; // 确保字符串以空字符结尾
    return result;
}

int main() {
    char command[] = "G()(al)";
    char * result = interpret(command);
    printf("%s\n", result);
    free(result); // 释放分配的内存
    return 0;
}