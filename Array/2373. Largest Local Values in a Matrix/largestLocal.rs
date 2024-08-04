impl Solution {
    pub fn largest_local(grid: Vec<Vec<i32>>) -> Vec<Vec<i32>> {
        let n = grid.len() - 2;
        let mut result = vec![vec![0; n]; n];
        
        for i in 0..n {
            for j in 0..n {
                let mut num = 0;
                for a in i..i+3 {
                    for b in j..j+3 {
                        if grid[a][b] > num {
                            num = grid[a][b];
                        }
                    }
                }
                result[i][j] = num;
            }
        }
        
        result
    }
}