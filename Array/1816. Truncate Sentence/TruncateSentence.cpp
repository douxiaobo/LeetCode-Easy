#include <iostream>
#include <string>

using namespace std;

class Solution {
public:
    string truncateSentence(string s, int k) {
        string result = "";
        for (char ch : s) {
            if (ch == ' ') {
                k--;
            }
            if (k == 0) {
                break;
            }
            result += ch;
        }
        return result;
    }
};

int main() {
    Solution sol;
    string str = "Hello how are you Contestant";
    int k = 4;
    string result = sol.truncateSentence(str, k);
    cout << "Truncated sentence: " << result << endl;
    return 0;
}