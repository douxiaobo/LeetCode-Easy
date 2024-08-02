#include <vector>
#include <iostream>

class Solution {
public:
    bool canBeIncreasing(vector<int>& nums) {
        for(int i=0;i<nums.size();i++){
            std::vector<int> myvector;
            for(int j=0;j<nums.size();j++){
                if(i!=j){
                    myvector.push_back(nums[j]);
                }
            }
            bool increasing=true;
            for(int k=0;k<myvector.size()-1;k++){
                if(myvector[k]>=myvector[k+1]){
                    increasing=false;
                }
            }
            if(increasing==true){
                return true;
            }
        }
        return false;
    }
};

// Example usage and test function
int main() {
    Solution sol;
    std::vector<int> nums1 = {1, 2, 10, 5, 7};
    std::vector<int> nums2 = {2, 3, 1, 2};
    
    std::cout << "Test 1: " << (sol.canBeIncreasing(nums1) ? "Pass" : "Fail") << std::endl;
    std::cout << "Test 2: " << (sol.canBeIncreasing(nums2) ? "Pass" : "Fail") << std::endl;

    return 0;
}