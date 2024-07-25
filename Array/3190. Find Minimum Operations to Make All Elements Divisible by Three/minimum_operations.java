class Solution {
    public int minimumOperations(int[] nums) {
        int result=0;
        for(int i=0;i<nums.length;i++){
            if(nums[i]%3!=0){
                result++;
            }
        }
        return result;
    }
    public static void main(String[] args) {
        Solution sol = new Solution();
        int[] nums1 = {1, 2, 3, 4};
        int[] nums2 = {3, 6, 9};

        System.out.println("Minimum operations for nums1: " + sol.minimumOperations(nums1));
        System.out.println("Minimum operations for nums2: " + sol.minimumOperations(nums2));
    }
}