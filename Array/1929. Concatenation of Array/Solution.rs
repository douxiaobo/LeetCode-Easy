impl Solution {
    pub fn get_concatenation(nums: Vec<i32>) -> Vec<i32> {
        let mut res=Vec::with_capacity(nums.len()*2);
        res.resize(nums.len()*2,0);
        for i in 0..nums.len(){
            res[i]=nums[i];
            res[i+nums.len()]=nums[i];
        }
        res
    }
}