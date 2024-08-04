namespace C_;

public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int[][] result = new int[grid.Length-2][];
        for (int i = 0; i < grid.Length-2; i++) {  
            result[i] = new int[grid.Length-2];
        }  
        for(int i=0;i<grid.Length-2;i++){
            for(int j=0;j<grid.Length-2;j++){
                int num=0;
                for(int a=i;a<i+3;a++){
                    for(int b=j;b<j+3;b++){
                        if(grid[a][b]>num){
                            num=grid[a][b];
                        }
                    }
                }
                result[i][j]=num;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2373. Largest Local Values in a Matrix/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Array/2373. Largest Local Values in a Matrix/C#/C#.csproj (in 1.54 sec).
// 已成功还原。


// douxiaobo@192 C# % 