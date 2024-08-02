class Solution {
    public boolean canBeIncreasing(int[] nums) {
        for (int i = 0; i < nums.length; i++) {
            List<Integer> myList = new ArrayList<>();
            for (int j = 0; j < nums.length; j++) {
                if (i != j) {
                    myList.add(nums[j]);
                }
            }
            boolean increasing = true;
            for (int k = 0; k < myList.size() - 1; k++) {
                if (myList.get(k) >= myList.get(k + 1)) {
                    increasing = false;
                }
            }
            if (increasing) {
                return true;
            }
        }
        return false;
    }
}