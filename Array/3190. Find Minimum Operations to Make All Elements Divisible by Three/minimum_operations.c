#include <stdio.h>
int minimumOperations(int* nums, int numsSize) {
    int result=0;
    for(int i=0;i<numsSize;i++){
        if(nums[i]%3!=0){
            result++;
        }
    }
    return result;
}

int minimumOperations1(int* nums, int numsSize) {
    int result = 0;
    for (int i = 0; i < numsSize; i++) {
        if (nums[i] % 3 != 0) {
            // 检查是否可以通过加1或减1使元素变为3的倍数
            if ((nums[i] + 1) % 3 == 0 || (nums[i] - 1) % 3 == 0) {
                result++;
            } else {
                // 如果既不能加1也不能减1使元素变为3的倍数，那么需要2次操作
                result += 2;
            }
        }
    }
    return result;
}


int main() {
    int nums1[] = {1, 2, 3, 4};
    int nums2[] = {3, 6, 9};
    int nums1Size = sizeof(nums1) / sizeof(nums1[0]);
    int nums2Size = sizeof(nums2) / sizeof(nums2[0]);

    printf("Minimum operations for nums1: %d\n", minimumOperations(nums1, nums1Size));
    printf("Minimum operations for nums2: %d\n", minimumOperations(nums2, nums2Size));

    return 0;
}