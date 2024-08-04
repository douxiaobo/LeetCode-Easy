impl Solution {
    pub fn find_permutation_difference(s: String, t: String) -> i32 {
        let mut index = [0; 26];
        for (i, ch) in s.chars().enumerate() {
            index[(ch as usize) - ('a' as usize)] = i;
        }
        let mut result = 0;
        for (i, ch) in t.chars().enumerate() {
            let mut diff = index[(ch as usize) - ('a' as usize)] as i32 - i as i32;
            if diff < 0 {
                diff = -diff;
            }
            result += diff;
        }
        result

    }
}