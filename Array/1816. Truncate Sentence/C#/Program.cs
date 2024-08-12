namespace C_;
public class Solution {
    public string TruncateSentence(string s, int k) {
        string result="";
        foreach(char ch in s){
            if(ch==' '){
                k--;
            }
            if(k==0){
                break;
            }
            result+=ch;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1816. Truncate Sentence/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1816. Truncate Sentence/C#/C#.csproj (in 754 ms).
// 已成功还原。


// douxiaobo@192 C# % 