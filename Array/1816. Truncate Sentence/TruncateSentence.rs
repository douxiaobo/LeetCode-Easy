struct Solution;

impl Solution {
    pub fn truncate_sentence(s: String, k: i32) -> String {
        let mut result = String::new();
        let mut count = k;

        for ch in s.chars() {
            if ch == ' ' {
                count -= 1;
            }
            if count == 0 {
                break;
            }
            result.push(ch);
        }

        result
    }
}

fn main() {
    let s = String::from("Hello how are you Contestant");
    let k = 4;
    let result = Solution::truncate_sentence(s, k);
    println!("Truncated sentence: {}", result);
}