namespace C_;
public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int[] index=new int[26];
        for(int i=0;i<s.Length;i++){
            index[s[i]-'a']=i;
        }
        int result=0;
        for(int i=0;i<t.Length;i++){
            if(index[t[i]-'a']>i){
                index[t[i]-'a']=index[t[i]-'a']-i;
            } else {
                index[t[i]-'a']=i-index[t[i]-'a'];
            }
            result+=index[t[i]-'a'];
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
