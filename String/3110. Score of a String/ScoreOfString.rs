struct Solution;
impl Solution {
    pub fn score_of_string(s: String) -> i32 {
        let mut score = 0;
        let bytes = s.as_bytes();

        for i in 0..bytes.len() - 1 {
            if bytes[i] > bytes[i + 1] {
                score += bytes[i] as i32 - bytes[i + 1] as i32;
            } else {
                score += bytes[i + 1] as i32 - bytes[i] as i32;
            }
        }

        score
    }
}

fn main() {
    println!("{}", Solution::score_of_string(String::from("hello")));
    println!("{}", Solution::score_of_string(String::from("zaz")));
}