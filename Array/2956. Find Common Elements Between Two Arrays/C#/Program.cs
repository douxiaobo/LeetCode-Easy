namespace C_;

public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        int num1=0,num2=0;
        for(int i=0;i<nums1.Length;i++){
            for(int j=0;j<nums2.Length;j++){
                if(nums1[i]==nums2[j]){
                    num1++;
                    break;
                }
            }
        }
        for(int i=0;i<nums2.Length;i++){
            for(int j=0;j<nums1.Length;j++){
                if(nums2[i]==nums1[j]){
                    num2++;
                    break;
                }
            }
        }
        return new int[2]{num1,num2};
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2956. Find Common Elements Between Two Arrays/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2956. Find Common Elements Between Two Arrays/C#/C#.csproj (in 786 ms).
// 已成功还原。


// douxiaobo@192 C# % 