impl Solution {
    pub fn count_prefix_suffix_pairs(words: Vec<String>) -> i32 {
        let mut result=0;
        for i in 0..words.len()-1{
            for j in i+1..words.len(){
                if(words[i].len()<=words[j].len()){
                    if(words[i]==words[j][0..words[i].len()]&&words[i]==words[j][words[j].len()-words[i].len()..words[j].len()]){
                        result+=1;
                    }
                }
            }
        }
        result
    }
}