struct Solution;

impl Solution {
    pub fn interpret(command: String) -> String {
        let mut result = String::new();
        let mut bracket = false;
        let mut temp = String::new();
        for ch in command.chars() {
            if ch == '(' {
                bracket = true;
            } else if ch == ')' {
                if temp.is_empty() {
                    result.push('o');
                } else {
                    result.push_str(&temp);
                    temp.clear();
                }
                bracket = false;
            } else if bracket {
                temp.push(ch);
            } else {
                result.push(ch);
            }
        }
        result
    }
}

fn main() {
    let command = String::from("G()(al)");
    let result = Solution::interpret(command);
    println!("{}", result);
}