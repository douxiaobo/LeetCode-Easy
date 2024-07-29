#include <stdlib.h>  
  
/**  
 * Note: The returned array must be malloced, assume caller calls free().  
 */  
double* convertTemperature(double celsius, int* returnSize) {  
    *returnSize = 2; // 设置返回数组的大小为2  
    double* result = (double*)malloc(*returnSize * sizeof(double)); // 分配内存  
    if (result == NULL) {  
        // 如果内存分配失败，这里应该处理错误，但在这个简单的示例中我们直接返回NULL  
        *returnSize = 0; // 将返回大小设置为0，表示发生了错误  
        return NULL;  
    }  
      
    // 填充返回数组  
    result[0] = celsius + 273.15; // 将摄氏度转换为开尔文  
    result[1] = celsius * 1.8 + 32; // 将摄氏度转换为华氏度  
      
    return result; // 返回分配并填充好的数组  
}  
  
int main() {  
    int returnSize;  
    double* temperatures = convertTemperature(0.0, &returnSize);  
    if (temperatures != NULL) {  
        // 假设我们只在成功时打印输出  
        printf("[%f, %f]\n", temperatures[0], temperatures[1]); // 输出: [273.150000, 32.000000]  
        free(temperatures); // 释放之前分配的内存  
    } else {  
        // 处理内存分配失败的情况  
        printf("Memory allocation failed.\n");  
    }  
    return 0;  
}