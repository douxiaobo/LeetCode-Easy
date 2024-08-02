bool canBeIncreasing(int* nums, int numsSize) {
    for (int i = 0; i < numsSize; i++) {
        int* temp = (int*)malloc((numsSize - 1) * sizeof(int));
        int index = 0;
        for (int j = 0; j < numsSize; j++) {
            if (i != j) {
                temp[index++] = nums[j];
            }
        }
        bool increasing = true;
        for (int k = 0; k < numsSize - 2; k++) {
            if (temp[k] >= temp[k + 1]) {
                increasing = false;
            }
        }
        if (increasing) {
            free(temp);
            return true;
        }
        free(temp);
    }
    return false;
}