use std::collections::HashMap;

impl Solution {
    pub fn is_anagram(s: String, t: String) -> bool {
        if s.len()!=t.len(){
            return false;
        }

        let mut map=HashMap::new();

        //计算s中每个字母的数量
        for c in s.chars(){
            let count=map.entry(c).or_insert(0);
            *count+=1;
        }

        //用t减去每个字母的数量
        for c in t.chars(){
            let count=map.entry(c).or_insert(0);
            *count-=1;

            //如果计数器低于零，说明t包含了一个不在s的额外字母，立即返回false
            if *count<0{
                return false;
            }
        }

        return true;
    }
}