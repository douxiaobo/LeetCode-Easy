int singleNumber(int* nums, int numsSize){
    int result;
    for(int i=0;i<numsSize;i++)
    {
        for(int j=0;j<numsSize;j++)
        {
            if((nums[i]==nums[j])&&(i!=j))
            {break;}
            if(j==numsSize-1)
            {result=nums[i];}
        }
    }
    return result;
}