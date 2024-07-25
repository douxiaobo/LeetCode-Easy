namespace _3190._Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three;

class Program
{
    public int MinimumOperations(int[] nums) {
        int result=0;
        for(int i=0;i<nums.Length;i++){
            if(((nums[i]+1)%3==0)||((nums[i]-1)%3==0)){
                result++;
            }
        }
        return result;
    }

    public static int MinimumOperations1(int[] nums) 
    {
        int result = 0;
        foreach (var num in nums)
        {
            if (num % 3 != 0)
            {
                // Check if adding or subtracting 1 makes the number divisible by 3.
                if ((num + 1) % 3 == 0 || (num - 1) % 3 == 0)
                {
                    result++;
                }
                else
                {
                    // If neither adding nor subtracting 1 works, we need to perform 2 operations.
                    result += 2;
                }
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        int[] nums1 = {1, 2, 3, 4};
        int[] nums2 = {3, 6, 9};

        Console.WriteLine($"Minimum operations for nums1: {MinimumOperations(nums1)}");
        Console.WriteLine($"Minimum operations for nums2: {MinimumOperations(nums2)}");
    }
}


// Last login: Thu Jul 25 14:06:12 on ttys000
// douxiaobo@192 3190. Find Minimum Operations to Make All Elements Divisible by Three % code .
// douxiaobo@192 3190. Find Minimum Operations to Make All Elements Divisible by Three % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/3190. Find Minimum Operations to Make All Elements Divisible by Three/3190. Find Minimum Operations to Make All Elements Divisible by Three.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/3190. Find Minimum Operations to Make All Elements Divisible by Three/3190. Find Minimum Operations to Make All Elements Divisible by Three.csproj (in 1.33 sec).
// 已成功还原。


// douxiaobo@192 3190. Find Minimum Operations to Make All Elements Divisible by Three % 

