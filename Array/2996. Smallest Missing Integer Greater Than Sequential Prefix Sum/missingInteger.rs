pub struct Solution;

impl Solution {
    pub fn missing_integer(nums: Vec<i32>) -> i32 {
        if nums.is_empty() {
            return 1; // 如果数组为空，返回1
        }
        let mut sum = nums[0];
        let mut prefix;
        for i in 1..nums.len() {
            if nums[i - 1] == nums[i] - 1 {
                sum += nums[i];
            } else {
                break;
            }
        }
        loop {
            prefix = true;
            for &num in &nums {
                if num == sum {
                    sum += 1;
                    prefix = false;
                }
            }
            if prefix {
                break;
            }
        }
        sum
    }
}