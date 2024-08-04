namespace C_;

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] result=new int[nums.Length];
        int index=0;
        for(int i=0;i<nums.Length/2;i++){
            result[index++]=nums[i];
            result[index++]=nums[i+n];
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1470. Shuffle the Array/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1470. Shuffle the Array/C#/C#.csproj (in 68 ms).
// 已成功还原。


// douxiaobo@192 C# % 