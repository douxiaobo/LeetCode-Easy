struct Solution;

impl Solution {
    pub fn find_intersection_values(nums1: Vec<i32>, nums2: Vec<i32>) -> Vec<i32> {
        let mut num1 = 0;
        let mut num2 = 0;
        
        for &num in &nums1 {
            for &val in &nums2 {
                if num == val {
                    num1 += 1;
                    break;
                }
            }
        }
        
        for &num in &nums2 {
            for &val in &nums1 {
                if num == val {
                    num2 += 1;
                    break;
                }
            }
        }
        
        vec![num1, num2]
    }
}

// 示例用法
fn main() {
    let nums1 = vec![1, 2, 3, 4, 5];
    let nums2 = vec![3, 4, 5, 6, 7];
    let result = Solution::find_intersection_values(nums1, nums2);
    println!("Intersection counts: [{}, {}]", result[0], result[1]);
}