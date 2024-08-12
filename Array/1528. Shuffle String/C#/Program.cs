namespace C_;
public class Solution {
    public string RestoreString(string s, int[] indices) {
        StringBuilder sb = new StringBuilder(s.Length);  
  
        // 遍历 indices 数组，并将 s 中的字符添加到 StringBuilder 的正确位置  
        for (int i = 0; i < indices.Length; i++) {  
            sb.Insert(indices[i], s[i]); // 在指定索引处插入字符  
        }  
  
        // 注意：如果 indices 数组中有重复的索引，后面的插入会覆盖前面的插入  
        // 但在这个问题中，我们假设 indices 数组是有效的，即每个索引只被使用一次  
  
        // 由于 StringBuilder 可能会因为插入操作而在末尾留下额外的空字符，  
        // 我们需要截断它到正确的长度（但在这个特定的问题中，由于 indices 覆盖了所有索引，所以这一步实际上是多余的）  
  
        return sb.ToString();  
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1528. Shuffle String/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1528. Shuffle String/C#/C#.csproj (in 591 ms).
// 已成功还原。


// douxiaobo@192 C# % 