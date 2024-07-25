struct Solution;

impl Solution {
    pub fn minimum_operations(nums: Vec<i32>) -> i32 {
        let mut result=0;
        for num in nums.iter(){
            if num%3!=0 {
                if (num+1)%3==0 || (num-1)%3==0 {
                    result+=1
                }
            }
        }
        result
    }
    pub fn minimum_operations1(nums: Vec<i32>) -> i32 {
        let mut result = 0;
        for &num in nums.iter() {
            match num % 3 {
                1 | 2 => result += 1, // 如果num对3取模的结果是1或2，增加操作计数
                _ => (), // 如果num能被3整除，不做任何操作
            }
        }
        result
    }
}

fn main(){
    let nums1 = vec![1, 2, 3, 4];
    let nums2 = vec![3, 6, 9];

    println!("Minimum operations for nums1: {}", Solution::minimum_operations(nums1));
    println!("Minimum operations for nums2: {}", Solution::minimum_operations(nums2));
}