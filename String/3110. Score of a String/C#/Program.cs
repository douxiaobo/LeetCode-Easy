using System;
using System.Collections.Generic;
class Program
{
    public int ScoreOfString(string s){
        // HashSet<char> set = new HashSet<char>();
        // for(int i = 0; i < s.Length; i++){
        //     set.Add(s[i]);
        // }
        int score = 0;
        // foreach (var c in set)
        // {
        //     Console.WriteLine(c);
        //     score += c;
        // }
        // Console.WriteLine(set);
        // foreach(var c1 in set){
        //     foreach(var c2 in set){
        //         if(c1==c2){
        //             continue;
        //         } else {
        //             if(c1>=c2){
        //                 score+=c1-c2;
        //             } else {
        //                 score+=c2-c1;
        //             }
        //         }
        //     }
        // }
        for(int i=0;i<s.Length-1;i++){
            if(s[i]>s[i+1]){
                score+=s[i]-s[i+1];
            } else {
                score+=s[i+1]-s[i];
            }
        }
        return score;

    }
    static void Main(string[] args)
    {
        Program programInstance = new Program();
        // Console.WriteLine("Hello, World!");
        Console.WriteLine(programInstance.ScoreOfString("hello"));   //13
        Console.WriteLine(programInstance.ScoreOfString("zaz"));     //50
    }
}


// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Coding/LeetCode-Easy/String/3110. Score of a String/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Coding/LeetCode-Easy/String/3110. Score of a String/C#/C#.csproj (in 1.65 sec).
// 已成功还原。


// douxiaobo@192 C# % 



// public class Solution {
//     public int ScoreOfString(string s) {
//         int score=0;
//         for(int i=0;i<s.Length-1;i++){
//             if(s[i]>s[i+1]){
//                 score+=s[i]-s[i+1];
//             } else {
//                 score+=s[i+1]-s[i];
//             }
//         }
//         return score;
//     }
// }
