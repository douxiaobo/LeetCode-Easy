struct Solution;

impl Solution {
    pub fn plus_one(digits: Vec<i32>) -> Vec<i32> {
        let mut result=digits.clone();
        let mut i=result.len()-1;
        loop{
            //数字非9，直接加一返回
            if result[i]<9{
                result[i]+=1;
                return result;
            }

            //数字是9，将其置为0
            result[i]=0;
            if i>0 {
                i-=1;
            } else if i==0 {
                //全部数字是9，跳出循环
                break;
            }
        }

        //重置数组，数组长度因进位而加一，除第一个元素为1外，其余元素皆为0
        result=vec![0;result.len()+1];
        result[0]=1;
        return result;
    }
}


fn main(){
	let vec:Vec<i32>=vec![9,9,9,9,9];
	println!("{:?}",Solution::plus_one(vec.clone()));
}

