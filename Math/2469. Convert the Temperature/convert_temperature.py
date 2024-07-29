from typing import List  
  
class Solution:  
    def convertTemperature(self, celsius: float) -> List[float]:  
        kelvin = celsius + 273.15  
        fahrenheit = celsius * 1.8 + 32  
        return [kelvin, fahrenheit]  
  
# 示例用法  
solution = Solution()  
temperatures = solution.convertTemperature(0.0)  
print(temperatures)  # 输出: [273.15, 32.0]