namespace C_;

public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        for(int i=0;i<nums.Length;i++){
            int[] temp=new int[nums.Length-1];
            int index=0;
            for(int j=0;j<nums.Length;j++){
                if(i!=j){
                    temp[index++]=nums[j];
                }
            }
            bool increasing=true;
            for(int k=0;k<temp.Length-1;k++){
                if(temp[k]>=temp[k+1]){
                    increasing=false;
                }
            }
            if(increasing==true){
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// douxiaobo@192 C# % dotnet new console --framework  net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1909. Remove One Element to Make the Array Strictly Increasing/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/1909. Remove One Element to Make the Array Strictly Increasing/C#/C#.csproj (in 1.38 sec).
// 已成功还原。


// douxiaobo@192 C# % 