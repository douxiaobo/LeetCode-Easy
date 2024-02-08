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
    pub fn min_depth(root: Option<Rc<RefCell<TreeNode>>>) -> i32 {
        match root {
            Some(node)=>{
                //左子树为空，返回右子树的最小深度
                if node.borrow().left.is_none() {
                    return Self::min_depth(node.borrow().right.clone())+1;
                }
                //右子树为空，返回左子树的最小深度
                if node.borrow().right.is_none() {
                    return Self::min_depth(node.borrow().left.clone())+1;
                }

                //左、右子树都不为空，返回左、右子树尝试的较小值
                let left=Self::min_depth(node.borrow().left.clone());
                let right=Self::min_depth(node.borrow().right.clone());
                left.min(right)+1
            },
            Node=>0,
        }
    }
}