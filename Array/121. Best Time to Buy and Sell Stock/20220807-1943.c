int maxProfit(int* prices, int pricesSize){
    int diff=0;
    int min=prices[0];
    for(int i=1;i<pricesSize;i++)
    {
        if(min>prices[i])
            min=prices[i];
        if(prices[i]-min>diff)
            diff=prices[i]-min;
    }
    return diff;
}