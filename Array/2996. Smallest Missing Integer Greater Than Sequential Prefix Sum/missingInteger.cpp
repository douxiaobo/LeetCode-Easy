#include <vector>

class Solution {
public:
    int missingInteger(std::vector<int>& nums) {
        int sum = nums[0];
        bool prefix;
        for (int i = 1; i < nums.size(); i++) {
            if (nums[i - 1] == nums[i] - 1) {
                sum += nums[i];
            } else {
                break;
            }
        }
        while (true) {
            prefix = true;
            for (int i = 0; i < nums.size(); i++) {
                if (nums[i] == sum) {
                    sum++;
                    prefix = false;
                }
            }
            if (prefix == true) {
                break;
            }
        }
        return sum;
    }
};