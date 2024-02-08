impl Solution {
    pub fn climb_stairs(n: i32) -> i32 {
        let mut memo: Vec<i32> = vec![0; n as usize];
        return recursion(n as usize, &mut memo);
    }
}

fn recursion(n: usize, memo: &mut Vec<i32>) -> i32 {
    //对应模板：递归终止条件
    if n<=2 {
        return n as i32;
    }

    //对应模板：下探到下一层
    //到达第n-1阶的方法数
    if memo[n-1]==0 {
        memo[n-1]=recursion(n-1,memo);
    }

    //对应模板：下探到下一层
    //到达第n-2阶的方法数
    if memo[n-2]==0 {
        memo[n-2]=recursion(n-2,memo);
    }

    //到达第n阶的方法数是到达第n-1阶和第n-2阶的方法数之和
    return memo[n-1]+memo[n-2];
}