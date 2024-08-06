namespace C_;

public class Solution {
    public int MissingInteger(int[] nums) {
        int sum=nums[0];
        bool prefix;
        for(int i=1;i<nums.Length;i++){
            if(nums[i-1]==nums[i]-1){
                sum+=nums[i];
            } else {
                break;
            }
        }
        while(true){
            prefix=true;
            for(int i=0;i<nums.Length;i++){
                if(nums[i]==sum){
                    sum++;
                    prefix=false;
                }
            }
            if(prefix==true){
                break;
            }
        }
        return sum;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2996. Smallest Missing Integer Greater Than Sequential Prefix Sum/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2996. Smallest Missing Integer Greater Than Sequential Prefix Sum/C#/C#.csproj (in 1.55 sec).
// 已成功还原。


// douxiaobo@192 C# % 