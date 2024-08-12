#include <vector>

using namespace std;

class Solution {
public:
    vector<int> findIntersectionValues(vector<int>& nums1, vector<int>& nums2) {
        int num1 = 0, num2 = 0;
        
        for (int i = 0; i < nums1.size(); i++) {
            for (int j = 0; j < nums2.size(); j++) {
                if (nums1[i] == nums2[j]) {
                    num1++;
                    break;
                }
            }
        }
        
        for (int i = 0; i < nums2.size(); i++) {
            for (int j = 0; j < nums1.size(); j++) {
                if (nums2[i] == nums1[j]) {
                    num2++;
                    break;
                }
            }
        }
        
        return {num1, num2};
    }
};
