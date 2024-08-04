namespace C_;
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result=0;
        foreach(char j in jewels){
            foreach(char s in stones){
                if(j==s){
                    result++;
                }
            }
        }
        return result;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/771. Jewels and Stones/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/771. Jewels and Stones/C#/C#.csproj (in 1.5 sec).
// 已成功还原。

