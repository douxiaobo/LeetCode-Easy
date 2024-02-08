struct Solution;

impl Solution {
    pub fn move_zeroes(nums: &mut Vec<i32>) {
        let mut i=0;
        for j in 0..nums.len(){
            //将非零元素按顺序存入数组的0至i-1位置
            if nums[j]!=0 {		//不应该有括号，否则报错。报错如下：
                nums[i]=nums[j];
                i+=1;
            }
        }
        //把剩余部分全部设置为0
        for k in i..nums.len(){
            nums[k]=0;
        }
    }
}

fn main(){
	let mut vec:Vec<i32>=vec![0,1,0,3,12];
	Solution::move_zeroes(&mut vec);
	println!("{:?}",vec);
}

//warning: unnecessary parentheses around `if` condition
// --> main.rs:8:15
//  |
//8 |             if(nums[j]!=0){
//  |               ^          ^
//  |
//  = note: `#[warn(unused_parens)]` on by default
//help: remove these parentheses
//  |
//8 -             if(nums[j]!=0){
//8 +             if nums[j]!=0 {
//  |
//
//warning: 1 warning emitted