#include <stdio.h>
#include <stdlib.h>

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* findIntersectionValues(int* nums1, int nums1Size, int* nums2, int nums2Size, int* returnSize) {
    int num1 = 0, num2 = 0;
    int* result = (int*)malloc(2 * sizeof(int));
    
    for (int i = 0; i < nums1Size; i++) {
        for (int j = 0; j < nums2Size; j++) {
            if (nums1[i] == nums2[j]) {
                num1++;
                break;
            }
        }
    }
    
    for (int i = 0; i < nums2Size; i++) {
        for (int j = 0; j < nums1Size; j++) {
            if (nums2[i] == nums1[j]) {
                num2++;
                break;
            }
        }
    }
    
    result[0] = num1;
    result[1] = num2;
    *returnSize = 2;
    
    return result;
}

// 示例用法
int main() {
    int nums1[] = {1, 2, 3, 4, 5};
    int nums2[] = {3, 4, 5, 6, 7};
    int returnSize;
    int* result = findIntersectionValues(nums1, 5, nums2, 5, &returnSize);
    
    printf("Intersection counts: [%d, %d]\n", result[0], result[1]);
    
    free(result);
    return 0;
}