use std::collections::HashMap;

struct Solution;

impl Solution {
    pub fn kth_distinct(arr: Vec<String>, k: i32) -> String {
        let mut dict: HashMap<String, i32> = HashMap::new();

        for str in &arr {
            let count = dict.entry(str.clone()).or_insert(0);
            *count += 1;
        }

        let mut count = 0;
        for str in &arr {
            if let Some(&1) = dict.get(str) {
                count += 1;
                if count == k {
                    return str.clone();
                }
            }
        }
        String::new()
    }
}

fn main() {
    let arr = vec!["a".to_string(), "b".to_string(), "a".to_string(), "c".to_string(), "b".to_string()];
    let k = 2;
    println!("{}", Solution::kth_distinct(arr, k)); // 输出 "c"
}