namespace C_;

public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> result=new List<int>();
        for(int i=0;i<words.Length;i++){
            for(int j=0;j<words[i].Length;j++){
                if(words[i][j]==x){
                    result.Add(i);
                    break;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2942. Find Words Containing Character/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2942. Find Words Containing Character/C#/C#.csproj (in 1.31 sec).
// 已成功还原。


// douxiaobo@192 C# % 