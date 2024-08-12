struct Solution;

impl Solution {
    pub fn kth_distinct(arr: Vec<String>, k: i32) -> String {
        let mut counts = vec![0; arr.len()];
        let mut indices = std::collections::HashMap::new();

        for (i, str) in arr.iter().enumerate() {
            if let Some(&index) = indices.get(str) {
                counts[index] += 1;
            } else {
                indices.insert(str, i);
                counts[i] = 1;
            }
        }

        let mut count = 0;
        for (i, &c) in counts.iter().enumerate() {
            if c == 1 {
                count += 1;
                if count == k {
                    return arr[i].clone();
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