impl Solution {
    pub fn can_be_increasing(nums: Vec<i32>) -> bool {
        for i in 0..nums.len() {
            let mut temp = Vec::with_capacity(nums.len() - 1);
            for j in 0..nums.len() {
                if i != j {
                    temp.push(nums[j]);
                }
            }
            let mut increasing = true;
            for k in 0..temp.len() - 1 {
                if temp[k] >= temp[k + 1] {
                    increasing = false;
                    break;
                }
            }
            if increasing {
                return true;
            }
        }
        false

    }
}