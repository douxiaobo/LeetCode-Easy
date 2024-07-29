using System;  
  
public class Solution {  
    public double[] ConvertTemperature(double celsius) {  
        double[] result = new double[2];  
        result[0] = celsius + 273.15; // 将摄氏度转换为开尔文  
        result[1] = celsius * 1.8 + 32; // 将摄氏度转换为华氏度  
        return result;  
    }  
}  
  
class Program {  
    static void Main(string[] args) {  
        Solution solution = new Solution();  
        double[] temperatures = solution.ConvertTemperature(0.0); // 示例：将 0 摄氏度转换为开尔文和华氏度  
        Console.WriteLine($"[{temperatures[0]}, {temperatures[1]}]"); // 输出: [273.15, 32]  
    }  
}


// douxiaobo@192 c# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Math/2469. Convert the Temperature/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Math/2469. Convert the Temperature/C#/C#.csproj (in 1.75 sec).
// 已成功还原。


// douxiaobo@192 c# % 
