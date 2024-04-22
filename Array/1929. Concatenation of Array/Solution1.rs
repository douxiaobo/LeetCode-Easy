impl Solution {
    pub fn get_concatenation(nums: Vec<i32>) -> Vec<i32> {
        let mut res=Vec::new();
        for i in 0..2{
            for j in 0..nums.len(){
                res.push(nums[j]);
            }
        }
        res
    }
}