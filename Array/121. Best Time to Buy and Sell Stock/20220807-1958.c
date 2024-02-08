int maxProfit(int* prices, int pricesSize){
    int diff=0;
    int min=prices[0];
    for(int i=1;i<pricesSize;i++)
    {
        if(min>prices[i])
            min=prices[i];
        else
            diff=(prices[i]-min)>diff?prices[i]-min:diff;
    }
    return diff;
}