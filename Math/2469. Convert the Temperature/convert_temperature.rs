struct Solution;  
  
impl Solution {  
    pub fn convert_temperature(celsius: f64) -> Vec<f64> {  
        let mut result = Vec::new(); // 创建一个空的 Vec<f64>  
        result.push(celsius + 273.15); // 将摄氏度转换为开尔文并添加到结果中  
        result.push(celsius * 1.8 + 32.0); // 将摄氏度转换为华氏度并添加到结果中  
        result // 返回结果  
    }  
}  
  
fn main() {  
    let solution = Solution {};  
    let temperatures = solution.convert_temperature(0.0); // 示例：将 0 摄氏度转换为开尔文和华氏度  
    println!("{:?}", temperatures); // 输出: [273.15, 32]  
}