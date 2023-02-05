int maxProfit(int* prices, int pricesSize){
    int max=0;
    int sum=0;
    for(int i=1;i<pricesSize;i++)
    {
        sum+=prices[i]-prices[i-1];
        if(sum>max)
            max=sum;
        if(sum<0)
            sum=0;
    }
    return max;
}