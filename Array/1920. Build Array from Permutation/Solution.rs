impl Solution {
    pub fn build_array(nums: Vec<i32>) -> Vec<i32> {
        let mut res=Vec::with_capacity(nums.len());
        for num in nums.iter(){
            res.push(nums[*num as usize]);
        }
        res
    }
}

impl Solution {
    pub fn build_array(nums: Vec<i32>) -> Vec<i32> {
        let mut res=Vec::with_capacity(nums.len());
        for i in 0..nums.len(){
            let t=nums[i] as usize;
            res.push(nums[t]);
        }
        res
    }
}

impl Solution {
    pub fn build_array(nums: Vec<i32>) -> Vec<i32> {
        let mut res=Vec::new();
        for i in 0..nums.len(){
            let t=nums[i] as usize;
            res.push(nums[t]);
        }
        res
    }
}
