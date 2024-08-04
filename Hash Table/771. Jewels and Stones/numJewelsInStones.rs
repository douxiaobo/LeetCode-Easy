impl Solution {
    pub fn num_jewels_in_stones(jewels: String, stones: String) -> i32 {
        let mut result = 0;
        for j in jewels.chars() {
            for s in stones.chars() {
                if j == s {
                    result += 1;
                }
            }
        }
        result
    }
}