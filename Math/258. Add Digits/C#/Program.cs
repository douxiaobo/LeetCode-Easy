namespace C_;
public class Solution {
    public int AddDigits(int num) {
        if(num%10==num){
            return num;
        }
        int result=0;
        while(num>0){
            result+=num%10;
            num=num/10;
        }
        return AddDigits(result);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main 
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Math/258. Add Digits/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Math/258. Add Digits/C#/C#.csproj (in 1.61 sec).
// 已成功还原。


// douxiaobo@192 C# % 