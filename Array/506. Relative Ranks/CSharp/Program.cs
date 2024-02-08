namespace _506._Relative_Ranks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int[] newscore=new int[score.Length];
        for(int i=0;i<score.Length;i++){
            newscore[i]=score[i];
        }
        Array.Sort(newscore,(a,b)=>b.CompareTo(a));
        string[] result=new string[score.Length];
        for(int i=0;i<newscore.Length;i++){
            for(int j=0;j<newscore.Length;j++){
                if(i==0&&newscore[i]==score[j]){
                    result[j]="Gold Medal";
                } else if(i==1&&newscore[i]==score[j]){
                    result[j]="Silver Medal";
                } else if(i==2&&newscore[i]==score[j]){
                    result[j]="Bronze Medal";
                } else if(i>2&&newscore[i]==score[j]){
                    result[j]=(i+1).ToString();
                }
            }
        }
        return result;
    }
}
public class Solution1 {
    public string[] FindRelativeRanks(int[] score) {
        int[] newscore=new int[score.Length];
        for(int i=0;i<score.Length;i++){
            newscore[i]=score[i];
        }
        BubbleSort(newscore);
        string[] result=new string[score.Length];
        for(int i=0;i<newscore.Length;i++){
            for(int j=0;j<newscore.Length;j++){
                if(i==0&&newscore[i]==score[j]){
                    result[j]="Gold Medal";
                } else if(i==1&&newscore[i]==score[j]){
                    result[j]="Silver Medal";
                } else if(i==2&&newscore[i]==score[j]){
                    result[j]="Bronze Medal";
                } else if(i>2&&newscore[i]==score[j]){
                    result[j]=(i+1).ToString();
                }
            }
        }
        return result;
    }
    public static void BubbleSort(int[] newscore){
        for(int i=0;i<newscore.Length-1;i++){
            for(int j=0;j<newscore.Length-i-1;j++){
                if(newscore[j]<newscore[j+1]){
                    Swap(newscore,j,j+1);
                }
            }
        }
    }
    public static void Swap(int[] newscore,int i,int j){
        int temp=newscore[i];
        newscore[i]=newscore[j];
        newscore[j]=temp;
    }
}
public class Solution2 {
    public string[] FindRelativeRanks(int[] score) {
        int[] newscore=new int[score.Length];
        for(int i=0;i<score.Length;i++){
            newscore[i]=score[i];
        }
        SelectionSort(newscore);
        string[] result=new string[score.Length];
        for(int i=0;i<newscore.Length;i++){
            for(int j=0;j<newscore.Length;j++){
                if(i==0&&newscore[i]==score[j]){
                    result[j]="Gold Medal";
                } else if(i==1&&newscore[i]==score[j]){
                    result[j]="Silver Medal";
                } else if(i==2&&newscore[i]==score[j]){
                    result[j]="Bronze Medal";
                } else if(i>2&&newscore[i]==score[j]){
                    result[j]=(i+1).ToString();
                }
            }
        }
        return result;
    }
    public static void SelectionSort(int[] newscore){
        for(int i=0;i<newscore.Length-1;i++){
            int minIndex=i;
            for(int j=i+1;j<newscore.Length;j++){
                if(newscore[j]>newscore[minIndex]){
                    minIndex=j;
                }
            }
            Swap(newscore,minIndex,i);
        }
    }
    public static void Swap(int[] newscore,int i,int j){
        int temp=newscore[i];
        newscore[i]=newscore[j];
        newscore[j]=temp;
    }
}
public class Solution3 {
    public string[] FindRelativeRanks(int[] score) {
        int[] newscore=new int[score.Length];
        for(int i=0;i<score.Length;i++){
            newscore[i]=score[i];
        }
        InsertionSort(newscore);
        string[] result=new string[score.Length];
        for(int i=0;i<newscore.Length;i++){
            for(int j=0;j<newscore.Length;j++){
                if(i==0&&newscore[i]==score[j]){
                    result[j]="Gold Medal";
                } else if(i==1&&newscore[i]==score[j]){
                    result[j]="Silver Medal";
                } else if(i==2&&newscore[i]==score[j]){
                    result[j]="Bronze Medal";
                } else if(i>2&&newscore[i]==score[j]){
                    result[j]=(i+1).ToString();
                }
            }
        }
        return result;
    }
    public static void InsertionSort(int[] newscore){
        for(int i=1;i<newscore.Length;i++){
            int key=newscore[i];
            int j=i-1;
            while(j>=0&&newscore[j]<key){
                newscore[j+1]=newscore[j];
                j=j-1;
            }
            newscore[j+1]=key;
        }
    }
}

