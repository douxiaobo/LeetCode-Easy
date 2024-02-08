int searchInsert(int* nums, int numsSize, int target){
    int index=0;
    for(int i=0;i<numsSize;i++)
    {
        if(nums[i]<target)
        {
            if(i+1==numsSize)
            {
                index=i+1;
                break;
            }
            else if(nums[i+1]>=target)
            {
                index=i+1;
                break;
            }
        }
        else if(nums[i]==target)
        {
            index=i;
            break;
        }
    }
    return index;
}