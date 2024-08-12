namespace C_;
public class Solution {
    public string DecodeMessage(string key, string message) {
        string result="";
        char[] letter=new char[26]; 
        int index=0;
        foreach(char ch in key){
            if((ch>='a'&&ch<='z')&&(letter[ch - 'a'] == '\0') ){
                letter[ch - 'a'] = (char)((int)'a' + index++);
            }            
        }
        foreach(char ch in message){
            if(ch>='a'&&ch<='z'){
                result+=letter[ch-'a'];
            } else {
                result+=ch;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/2325. Decode the Message/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/2325. Decode the Message/C#/C#.csproj (in 528 ms).
// 已成功还原。


// douxiaobo@192 C# % 