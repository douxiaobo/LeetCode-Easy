#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 定义一个结构体来存储字符串和其出现次数
typedef struct {
    char *str;
    int count;
} StringCount;

char* kthDistinct(char** arr, int arrSize, int k) {
    StringCount *dict = (StringCount *)malloc(arrSize * sizeof(StringCount));
    int dictSize = 0;

    // 统计每个字符串的出现次数
    for (int i = 0; i < arrSize; i++) {
        int found = 0;
        for (int j = 0; j < dictSize; j++) {
            if (strcmp(arr[i], dict[j].str) == 0) {
                dict[j].count++;
                found = 1;
                break;
            }
        }
        if (!found) {
            dict[dictSize].str = arr[i];
            dict[dictSize].count = 1;
            dictSize++;
        }
    }

    // 找到第k个独特的字符串
    int count = 0;
    for (int i = 0; i < dictSize; i++) {
        if (dict[i].count == 1) {
            count++;
            if (count == k) {
                return dict[i].str;
            }
        }
    }

    free(dict);
    return "";
}

int main() {
    char *arr[] = {"a", "b", "a", "c", "b"};
    int arrSize = 5;
    int k = 2;
    printf("%s\n", kthDistinct(arr, arrSize, k)); // 输出 "c"
    return 0;
}