int mySqrt(int x){
    long max=1;
    while(max*max<=x)
    {
        max++;
    }
    return max-1;
}