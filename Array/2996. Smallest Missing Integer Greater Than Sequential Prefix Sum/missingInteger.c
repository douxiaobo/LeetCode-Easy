#include <stdio.h>

int missingInteger(int* nums, int numsSize) {
    int sum = nums[0];
    int prefix;
    for (int i = 1; i < numsSize; i++) {
        if (nums[i - 1] == nums[i] - 1) {
            sum += nums[i];
        } else {
            break;
        }
    }
    while (1) {
        prefix = 1;
        for (int i = 0; i < numsSize; i++) {
            if (nums[i] == sum) {
                sum++;
                prefix = 0;
            }
        }
        if (prefix == 1) {
            break;
        }
    }
    return sum;
}

// 示例用法
int main() {
    int nums[] = {1, 2, 3, 5};
    int numsSize = sizeof(nums) / sizeof(nums[0]);
    int result = missingInteger(nums, numsSize);
    printf("Missing integer: %d\n", result);
    return 0;
}