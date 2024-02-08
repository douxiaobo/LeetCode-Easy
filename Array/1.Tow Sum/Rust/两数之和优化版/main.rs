use std::collections::HashMap;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut map:HashMap<i32,usize>=HashMap::new();
        for i in 0..nums.len(){
            let complement=target-nums[i];
            if map.contains_key(&complement){
                //存在目标元素，立即返回结果
                return vec![i as i32, map[&complement] as i32];
            }

            //不存在目标元素，将键-值对(nums[i],i)插入哈希表，继续遍历
            map.insert(nums[i],i);
        }
        return vec![];
    }
}