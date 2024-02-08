struct Solution;

impl Solution {
    pub fn remove_duplicates(nums: &mut Vec<i32>) -> i32 {
        if nums.len()==0 {
            return 0;
        }

        let mut i=0;
        for j in i..nums.len(){
            //判断是否为重复元素，如果是则路过重复项并递增j，否则复制元素并递增i
            if nums[i]!=nums[j]{
                if j-i>1{
                    nums[i+1]=nums[j];
                }
                i+=1;
            }
        }
        (i+1) as i32
    }
}

fn main(){
	let mut vec:Vec<i32>=vec![0,0,1,1,1,2,2,3,3,4];
	println!("{:?}",Solution::remove_duplicates(&mut vec));
}