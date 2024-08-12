namespace C_;
public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string,int> dict = new Dictionary<string, int>(); 

        foreach (string str in arr) {
            if (dict.ContainsKey(str)) {
                dict[str]++;
            } else {
                dict.Add(str, 1);
            }
        }
        int count = 0;
        foreach (string str in arr) {
            if (dict[str] == 1) { // Cast the result of ht[str] to int
                count++;
                if (count == k) {
                    return str;
                }
            }
        }
        return "";
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2053. Kth Distinct String in an Array/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2053. Kth Distinct String in an Array/C#/C#.csproj (in 1.58 sec).
// 已成功还原。


// douxiaobo@192 C# % 