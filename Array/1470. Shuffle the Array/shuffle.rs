impl Solution {
    pub fn shuffle(nums: Vec<i32>, n: i32) -> Vec<i32> {
        let mut result = vec![0; nums.len()];
        let mut index = 0;
        for i in 0..(nums.len() / 2) {
            result[index] = nums[i];
            index += 1;
            result[index] = nums[i + n as usize];
            index += 1;
        }
        result
    }
}