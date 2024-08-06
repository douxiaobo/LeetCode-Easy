namespace C_;
public class Solution {
    public string Interpret(string command) {
        string result="";
        bool bracket=false;
        string temp="";
        foreach(char ch in command){
            if(ch=='('){
                bracket=true;
            } else if(ch==')'){
                if(temp==""){
                    result+='o';
                } else {
                    result+=temp;
                    temp="";
                }
                bracket=false;
            } else if(bracket==true){
                temp+=ch;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/String/1678. Goal Parser Interpretation/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/String/1678. Goal Parser Interpretation/C#/C#.csproj (in 1.88 sec).
// 已成功还原。


// douxiaobo@192 C# % 