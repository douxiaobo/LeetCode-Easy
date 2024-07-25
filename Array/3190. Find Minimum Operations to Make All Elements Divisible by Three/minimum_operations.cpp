#include <vector>
#include <iostream>

class Solution {
public:
    int minimumOperations(vector<int>& nums) {
        int result=0;
        for(int i=0;i<nums.size();i++){
            if(nums[i]%3!=0){
                result++;
            }
        }
        return result;
    }
};

int main() {
    Solution sol;
    std::vector<int> nums1 = {1, 2, 3, 4};
    std::vector<int> nums2 = {3, 6, 9};

    std::cout << "Minimum operations for nums1: " << sol.minimumOperations(nums1) << std::endl;
    std::cout << "Minimum operations for nums2: " << sol.minimumOperations(nums2) << std::endl;

    return 0;
}