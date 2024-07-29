#include <vector>  
  
class Solution {  
public:  
    std::vector<double> convertTemperature(double celsius) {  
        double kelvin = celsius + 273.15;  
        double fahrenheit = celsius * 1.8 + 32;  
        std::vector<double> result = {kelvin, fahrenheit};  
        return result;  
    }  
};  
  
// 示例用法  
#include <iostream>  
  
int main() {  
    Solution solution;  
    std::vector<double> temperatures = solution.convertTemperature(0.0);  
    std::cout << "[" << temperatures[0] << ", " << temperatures[1] << "]" << std::endl;  
    return 0;  
}