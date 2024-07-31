namespace C_;
public class Solution {
    public bool EqualFrequency(string word) {
        int[] digit=new int[26];
        for(int i=0;i<word.Length;i++){
            digit[word[i]-'a']++;
        }
        for(int i=0;i<word.Length;i++){
            int index=word[i]-'a';
            digit[index]--;
            int freqs=0;
            bool temp=true;
            for(int j=0;j<26;j++){
                if(digit[j]!=0){
                    if(freqs==0){
                        freqs=digit[j];
                    }
                    if(freqs!=digit[j]){
                        temp=false;
                    }
                }
            }
            if(temp==true){
                return true;
            }
            digit[index]++;
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


// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main 
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/2423. Remove Letter To Equalize Frequency/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Hash Table/2423. Remove Letter To Equalize Frequency/C#/C#.csproj (in 1.6 sec).
// 已成功还原。


// douxiaobo@192 C# % 