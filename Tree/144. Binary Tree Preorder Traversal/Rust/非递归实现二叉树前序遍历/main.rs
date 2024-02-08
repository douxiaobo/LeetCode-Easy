// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//   pub val: i32,
//   pub left: Option<Rc<RefCell<TreeNode>>>,
//   pub right: Option<Rc<RefCell<TreeNode>>>,
// }
// 
// impl TreeNode {
//   #[inline]
//   pub fn new(val: i32) -> Self {
//     TreeNode {
//       val,
//       left: None,
//       right: None
//     }
//   }
// }
use std::rc::Rc;
use std::cell::RefCell;
impl Solution {
    pub fn preorder_traversal(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<i32> {
        let mut result=vec![];
        if root.is_none() { return result; }

        //使用栈来保存需要返回后处理的节点
        let mut stack: Vec<Rc<RefCell<TreeNode>>> = Vec::new();
        let mut r = root.clone();

        //满足当前节点非空或者栈非空时执行循环
        while r.is_some() || !stack.is_empty() {
            //若当前节点非空，访问当前节点值，将当前节点入栈，并进入其左子树访问
            while let Some(node) =r {
                result.push(node.borrow().val);
                stack.push(node.clone());
                r=node.borrow().left.clone();
            }

            //栈顶的节点出栈，并进入其右子树访问
            r=stack.pop();
            if let Some(node) = r{
                r=node.borrow().right.clone();
            }
        }
        result
    }
}