impl Solution {
    pub fn is_valid(s: String) -> bool {
        let chars: Vec<char>=s.chars().collect();
        //判断是否为空字符串，空字符串视为有效字符串
        if chars.len()==0{
            return true;
        }

        let mut stack: Vec<char>=Vec::new();
        for i in 0..chars.len(){
            if chars[i]=='(' {          //如果是左小括号，将右小括号入栈
                stack.push(')');
            } else if chars[i]=='['{    //如果是左中括号，将右中括号入栈
                stack.push(']');
            } else if chars[i]=='{'{    //如果是左大括号，将右大括号入栈
                stack.push('}');
            } else if stack.is_empty()||chars[i]!=stack.pop().unwrap(){
                //栈为空或与栈顶元素不相同为无效字符串
                return false;
            }
        }
        //匹配结束，栈为空代表是有效字符串，否则是无效字符串
        return stack.is_empty();
    }
}