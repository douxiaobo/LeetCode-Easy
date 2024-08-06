namespace C_;

public class Solution {
    public int FindCenter(int[][] edges) {
        int[] nums=new int[edges.Length*2];
        for(int i=0;i<edges.Length;i++){
            nums[edges[i][0]]++;
            nums[edges[i][1]]++;
        }
        int max=0;
        int result=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>max){
                max=nums[i];
                result=i;
            }
        }
        return result;
    }
}

public class Solution1 {
    public int FindCenter(int[][] edges) {
        int[] nums=new int[edges.Length+1];
        for(int i=0;i<edges.Length;i++){
            nums[edges[i][0]-1]++;
            nums[edges[i][1]-1]++;
        }
        int max=0;
        int result=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>max){
                max=nums[i];
                result=i+1;
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] edges = new int[][] { new int[] {1, 2}, new int[] {2, 3}, };
        int center = solution.FindCenter(edges);
        Console.WriteLine(center);
    }
}

// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Graph/1791. Find Center of Star Graph/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Graph/1791. Find Center of Star Graph/C#/C#.csproj (in 466 ms).
// 已成功还原。


// douxiaobo@192 C# % 