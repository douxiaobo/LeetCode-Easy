#include <string>

class Solution {
public:
    std::string interpret(std::string command) {
        std::string result = "";
        bool bracket = false;
        std::string temp = "";
        for (char ch : command) {
            if (ch == '(') {
                bracket = true;
            } else if (ch == ')') {
                if (temp == "") {
                    result += 'o';
                } else {
                    result += temp;
                    temp = "";
                }
                bracket = false;
            } else if (bracket) {
                temp += ch;
            } else {
                result += ch;
            }
        }
        return result;
    }
};