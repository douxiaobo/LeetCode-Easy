#include <vector>
#include <string>
#include <unordered_map>

using namespace std;

class Solution {
public:
    string kthDistinct(vector<string>& arr, int k) {
        unordered_map<string, int> dict;

        // 统计每个字符串的出现次数
        for (const string& str : arr) {
            dict[str]++;
        }

        int count = 0;
        // 找到第k个独特的字符串
        for (const string& str : arr) {
            if (dict[str] == 1) {
                count++;
                if (count == k) {
                    return str;
                }
            }
        }
        return "";
    }
};

int main() {
    Solution solution;
    vector<string> arr = {"a", "b", "a", "c", "b"};
    int k = 2;
    cout << solution.kthDistinct(arr, k) << endl; // 输出 "c"
    return 0;
}